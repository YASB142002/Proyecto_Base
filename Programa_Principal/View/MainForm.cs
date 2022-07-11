using Programa_Principal.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Principal
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.SizeChanged += new EventHandler(MainForm_SizeChanged);
            OpenFormInPanel(new View.FormButtons.Home_Form());
            //timer1.Start();
        }

        #region Responsive Form

        #region Acomodo del form
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.MainPanel.Region = region;
            this.Invalidate();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones basicos
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnMaximize.Visible = false;
            this.btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnMaximize.Visible = true;
            this.btnRestore.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void PanelDesktop_Resize(object sender, EventArgs e)
        {
            foreach (Form form in PanelDesktop.Controls)
            {
                form.Size = PanelDesktop.Size;
                form.DesktopLocation = new Point(0, 0);
            }
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.btnMaximize.Visible = false;
                this.btnRestore.Visible = true;
            }
            else
            {
                this.btnMaximize.Visible = true;
                this.btnRestore.Visible = false;
            }
        }
        #endregion


        #region Metods
        private Button currentButton;
        private void ActivateButtons(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButtons();
                    var form = FindForm();
                    Color color = ThemeColor.SelectThemeColor();
                    form.BackColor = color;
                    currentButton = (Button)btnSender;
                    lblTitel.Text = currentButton.Text;
                    Control panel = currentButton.Parent;
                    panel.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.ImageAlign = ContentAlignment.MiddleRight;
                    currentButton.BackColor = Color.FromArgb(135, 135, 135);
                    PanelTitle.BackColor = color;
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButtons()
        {
            var form = FindForm();
            lblTitel.Text = "Ventas locas";
            form.BackColor = Color.FromArgb(105, 105, 105);
            this.MinimumSize = new Size(820, 545);
            this.Size = new Size(820, 545);
            foreach (Control previousPanel in PanelButtons.Controls)
            {
                if (previousPanel.GetType() == typeof(Panel))
                {
                    previousPanel.BackColor = Color.FromArgb(135, 135, 135);
                    foreach (Button botton in previousPanel.Controls)
                    {
                        botton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        botton.TextImageRelation = TextImageRelation.ImageBeforeText;
                        botton.ImageAlign = ContentAlignment.MiddleLeft;
                        botton.BackColor = Color.DimGray;
                        PanelTitle.BackColor = Color.FromArgb(105, 105, 105);
                    }
                }
            }
        }
        private void OpenFormInPanel(object Oform)
        {
            if (this.PanelDesktop.Controls.Count > 0)
                this.PanelDesktop.Controls.RemoveAt(0);
            Form forminpanel = Oform as Form;
            forminpanel.TopLevel = false;
            forminpanel.FormBorderStyle = FormBorderStyle.None;
            forminpanel.Dock = DockStyle.Fill;
            forminpanel.Anchor = AnchorStyles.Bottom;
            forminpanel.Anchor = AnchorStyles.Top;
            forminpanel.Anchor = AnchorStyles.Left;
            forminpanel.Anchor = AnchorStyles.Right;
            forminpanel.Size = PanelDesktop.Size;
            this.PanelDesktop.Controls.Add(forminpanel);
            this.PanelDesktop.Tag = forminpanel;
            forminpanel.Show();
        }
        

        #endregion
        #region Events

        private void btnNewFact_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender);
            OpenFormInPanel(new View.FormButtons.New_Fact_Form());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender);
            OpenFormInPanel(new View.FormButtons.Menu_Form());
            this.MinimumSize = new Size(1010, 545);
        }

        private void btnBranch_office_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender);
            OpenFormInPanel(new View.FormButtons.Branch_Office_Form());
            this.MinimumSize = new Size(935, 545);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender);
            OpenFormInPanel(new View.FormButtons.History_Form());
            this.MinimumSize = new Size(1020, 489);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender);
            OpenFormInPanel(new View.FormButtons.Report());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender);
            OpenFormInPanel(new View.FormButtons.Account_Form());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            DisableButtons();
            OpenFormInPanel(new View.FormButtons.Home_Form());
        }
        #endregion

        

        private bool tick = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick)
            {
                this.btnAccount_Click(btnAccount, e);
                tick = false;
            }
            else
                timer1.Stop();
        }
    }
}
