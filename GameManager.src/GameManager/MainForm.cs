using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Button = System.Windows.Forms.Button;
using Control = System.Windows.Forms.Control;
using TextBox = System.Windows.Forms.TextBox;

namespace GameManager {
    public partial class MainForm : Form {
        private Button currentBtn;
        private Form currentChildForm;
        private LibaryForm libary;
        
        private readonly string arcConvPath = Path.Combine(Path.GetTempPath(), "arc_conv_r54.exe");

        public string StatusBarText {
            set {
                if (InvokeRequired) {
                    BeginInvoke(new MethodInvoker(() => statusStripLabel.Text = value));
                }
                else {
                    statusStripLabel.Text = value;
                }
            }
            get {
                return statusStripLabel.Text;
            }
        }
        
        public MainForm() {
            InitializeComponent();
            Icon = Properties.Resources.DLSIconVectorized;
            foreach (Control c in Controls) {
                c.Font = Settings.Instance.GlobalFont;
            }

            //Move the window to where it was in the previous session
            if (Settings.Instance.WindowPlacementSaved) {
                var placement = Settings.Instance.WindowPlacement;
                placement.flags = 0;
                placement.showCmd = placement.showCmd == 2 ? 1 : placement.showCmd; //Prevents the window from ever opening as minimized
                SetWindowPlacement(Handle, ref placement);
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
        }

        /// <summary>
        /// Highlights the Selected Button
        /// </summary>
        private void ActivateButtons(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtons();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(64, 68, 98);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        /// <summary>
        /// Reset the previous highlighted Button to normal
        /// </summary>
        private void DisableButtons()
        {
            if (currentBtn != null)
            {
                //Button
                currentBtn.BackColor = Color.FromArgb(79, 97, 139);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        /// <summary>
        /// Gets the list of games from the database and inserts them into the game list.
        /// </summary>
        private void OpenChildForm(Form childform)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        [DllImport("user32.dll")]
        private static extern bool SetWindowPlacement(IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll")]
        private static extern bool GetWindowPlacement(IntPtr hWnd, out WINDOWPLACEMENT lpwndpl);

        private void splitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNewGames_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender, RGBColors.color1);
            searchBox.Visible = false;
        }

        private void buttonLibary_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender, RGBColors.color2);
            libary = new LibaryForm(this);
            OpenChildForm(libary);
            searchBox.Visible = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender, RGBColors.color3);
            OpenChildForm(new SettingsForm());
            searchBox.Visible = false;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            ActivateButtons(sender, RGBColors.color4);
            searchBox.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            libary.seachBox_startSearch(this.searchBox.Text);
        }
    }
}
