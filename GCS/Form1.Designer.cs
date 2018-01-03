namespace GCS
{
    partial class GCS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);


        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.missionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missionStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionToolStripMenuItem,
            this.dataDisplayToolStripMenuItem,
            this.systemsCheckToolStripMenuItem,
            this.missionStatusToolStripMenuItem,
            this.checkListToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // missionToolStripMenuItem
            // 
            this.missionToolStripMenuItem.Name = "missionToolStripMenuItem";
            this.missionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.missionToolStripMenuItem.Text = "New Mission";
            // 
            // dataDisplayToolStripMenuItem
            // 
            this.dataDisplayToolStripMenuItem.Name = "dataDisplayToolStripMenuItem";
            this.dataDisplayToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.dataDisplayToolStripMenuItem.Text = "Data Display";
            this.dataDisplayToolStripMenuItem.Click += new System.EventHandler(this.dataDisplayToolStripMenuItem_Click);
            // 
            // systemsCheckToolStripMenuItem
            // 
            this.systemsCheckToolStripMenuItem.Name = "systemsCheckToolStripMenuItem";
            this.systemsCheckToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.systemsCheckToolStripMenuItem.Text = "Systems Check";
            this.systemsCheckToolStripMenuItem.Click += new System.EventHandler(this.systemsCheckToolStripMenuItem_Click);
            // 
            // missionStatusToolStripMenuItem
            // 
            this.missionStatusToolStripMenuItem.Name = "missionStatusToolStripMenuItem";
            this.missionStatusToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.missionStatusToolStripMenuItem.Text = "Mission Status";
            this.missionStatusToolStripMenuItem.Click += new System.EventHandler(this.missionStatusToolStripMenuItem_Click);
            // 
            // checkListToolStripMenuItem
            // 
            this.checkListToolStripMenuItem.Name = "checkListToolStripMenuItem";
            this.checkListToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.checkListToolStripMenuItem.Text = "Check List";
            this.checkListToolStripMenuItem.Click += new System.EventHandler(this.checkListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1078, 772);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Connected:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Accesible:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "no";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 158);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(660, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Never";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Last Update:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GCS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 225);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GCS";
            this.Text = "Ground Control Station";
            this.Load += new System.EventHandler(this.GCS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem missionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemsCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

