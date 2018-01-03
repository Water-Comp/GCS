namespace GCS
{
    partial class NewMission
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.newm = new System.Windows.Forms.RadioButton();
            this.join = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(52, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(192, 20);
            this.name.TabIndex = 2;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.White;
            this.ok.Location = new System.Drawing.Point(69, 128);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(135, 62);
            this.ok.TabIndex = 6;
            this.ok.Text = "confirm";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(53, 43);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(192, 20);
            this.server.TabIndex = 2;
            // 
            // newm
            // 
            this.newm.AutoSize = true;
            this.newm.Checked = true;
            this.newm.Location = new System.Drawing.Point(52, 82);
            this.newm.Name = "newm";
            this.newm.Size = new System.Drawing.Size(85, 17);
            this.newm.TabIndex = 7;
            this.newm.TabStop = true;
            this.newm.Text = "New Mission";
            this.newm.UseVisualStyleBackColor = true;
            // 
            // join
            // 
            this.join.AutoSize = true;
            this.join.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.join.Location = new System.Drawing.Point(143, 82);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(44, 17);
            this.join.TabIndex = 7;
            this.join.TabStop = true;
            this.join.Text = "Join";
            this.join.UseVisualStyleBackColor = true;
            // 
            // NewMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 211);
            this.Controls.Add(this.join);
            this.Controls.Add(this.newm);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "NewMission";
            this.Text = "NewMission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.RadioButton newm;
        private System.Windows.Forms.RadioButton join;
    }
}