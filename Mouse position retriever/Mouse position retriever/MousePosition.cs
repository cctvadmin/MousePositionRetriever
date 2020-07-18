using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_position_retriever {
    public partial class CACodeMousePosition : Form {
        public CACodeMousePosition() {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        bool beginMove = false;
        int currentXPosition;
        int currentYPosition;

        private void _MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                beginMove = true;
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }
        private void _MouseMove(object sender, MouseEventArgs e) {
            if (beginMove) {
                this.Left += MousePosition.X - currentXPosition;
                this.Top += MousePosition.Y - currentYPosition;
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }
        private void _MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                currentXPosition = 0;
                currentYPosition = 0;
                beginMove = false;
            }
        }
        /// <summary>
        /// close this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e) {
            this.Close();
        }
        /// <summary>
        /// click icon to web page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icon_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://www.cacode.ren");
        }
        /// <summary>
        /// start get mouse position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            this.x.Text = MousePosition.X.ToString();
            this.y.Text = MousePosition.Y.ToString();
        }
        /// <summary>
        /// to http://www.cacode.ren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            icon_Click(sender, e);
        }

        private void above_CheckedChanged(object sender, EventArgs e) {
            if (this.above.Checked) {
                this.TopMost = true;
            } else {
                this.TopMost = false;
            }
        }
    }
}
