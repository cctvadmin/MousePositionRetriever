namespace Mouse_position_retriever {
    partial class CACodeMousePosition {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CACodeMousePosition));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toBlog = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.above = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label2.Location = new System.Drawing.Point(138, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.x.Location = new System.Drawing.Point(210, 12);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(31, 35);
            this.x.TabIndex = 1;
            this.x.Text = "0";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.y.Location = new System.Drawing.Point(210, 74);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(31, 35);
            this.y.TabIndex = 1;
            this.y.Text = "0";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.Control;
            this.close.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(355, -3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 35);
            this.close.TabIndex = 1;
            this.close.Text = "x";
            this.toolTip1.SetToolTip(this.close, "Close window");
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Image = global::Mouse_position_retriever.Properties.Resources.iconMain;
            this.icon.Location = new System.Drawing.Point(1, 12);
            this.icon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 97);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            this.toolTip1.SetToolTip(this.icon, "You can click http://www.cacode.ren to view our blog");
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // toBlog
            // 
            this.toBlog.AutoSize = true;
            this.toBlog.LinkColor = System.Drawing.Color.DodgerBlue;
            this.toBlog.Location = new System.Drawing.Point(-2, 119);
            this.toBlog.Name = "toBlog";
            this.toBlog.Size = new System.Drawing.Size(317, 17);
            this.toBlog.TabIndex = 3;
            this.toBlog.TabStop = true;
            this.toBlog.Text = "You can click http://www.cacode.ren to view our blog";
            this.toolTip1.SetToolTip(this.toBlog, "You can click http://www.cacode.ren to view our blog");
            this.toBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toBlog_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // above
            // 
            this.above.AutoSize = true;
            this.above.Location = new System.Drawing.Point(321, 115);
            this.above.Name = "above";
            this.above.Size = new System.Drawing.Size(63, 21);
            this.above.TabIndex = 4;
            this.above.Text = "above";
            this.toolTip1.SetToolTip(this.above, "Select to display the window on top of other windows");
            this.above.UseVisualStyleBackColor = true;
            this.above.CheckedChanged += new System.EventHandler(this.above_CheckedChanged);
            // 
            // CACodeMousePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 137);
            this.Controls.Add(this.above);
            this.Controls.Add(this.toBlog);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.close);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CACodeMousePosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CACodeMousePosition";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel toBlog;
        private System.Windows.Forms.CheckBox above;
    }
}

