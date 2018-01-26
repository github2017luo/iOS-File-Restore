namespace iOS_File_Restore
{
    partial class Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "root password";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(12, 30);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(144, 20);
            this.ip.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 69);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(144, 20);
            this.pass.TabIndex = 3;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(11, 95);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(145, 23);
            this.go.TabIndex = 4;
            this.go.Text = "go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 129);
            this.Controls.Add(this.go);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "File Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button go;
    }
}

