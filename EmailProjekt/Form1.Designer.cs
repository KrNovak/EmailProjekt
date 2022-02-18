
namespace EmailProjekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pošiljatelj = new System.Windows.Forms.TextBox();
            this.txt_primatelj = new System.Windows.Forms.TextBox();
            this.txt_naslov = new System.Windows.Forms.TextBox();
            this.txt_poruka = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.pass_pošiljatelj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(393, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slanje Emaila pomoću C#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(67, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pošiljatelj: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(67, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primatelj: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(67, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Naslov: ";
            // 
            // txt_pošiljatelj
            // 
            this.txt_pošiljatelj.Location = new System.Drawing.Point(173, 202);
            this.txt_pošiljatelj.Name = "txt_pošiljatelj";
            this.txt_pošiljatelj.Size = new System.Drawing.Size(952, 20);
            this.txt_pošiljatelj.TabIndex = 3;
            // 
            // txt_primatelj
            // 
            this.txt_primatelj.Location = new System.Drawing.Point(173, 270);
            this.txt_primatelj.Name = "txt_primatelj";
            this.txt_primatelj.Size = new System.Drawing.Size(952, 20);
            this.txt_primatelj.TabIndex = 3;
            this.txt_primatelj.TextChanged += new System.EventHandler(this.txt_primatelj_TextChanged);
            // 
            // txt_naslov
            // 
            this.txt_naslov.Location = new System.Drawing.Point(173, 296);
            this.txt_naslov.Name = "txt_naslov";
            this.txt_naslov.Size = new System.Drawing.Size(952, 20);
            this.txt_naslov.TabIndex = 3;
            // 
            // txt_poruka
            // 
            this.txt_poruka.Location = new System.Drawing.Point(173, 322);
            this.txt_poruka.Name = "txt_poruka";
            this.txt_poruka.Size = new System.Drawing.Size(952, 333);
            this.txt_poruka.TabIndex = 4;
            this.txt_poruka.Text = "";
            this.txt_poruka.TextChanged += new System.EventHandler(this.txt_poruka_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(988, 713);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pošalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password.Location = new System.Drawing.Point(71, 238);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 22);
            this.Password.TabIndex = 6;
            this.Password.Text = "Lozinka:";
            // 
            // pass_pošiljatelj
            // 
            this.pass_pošiljatelj.Location = new System.Drawing.Point(173, 238);
            this.pass_pošiljatelj.Name = "pass_pošiljatelj";
            this.pass_pošiljatelj.PasswordChar = '*';
            this.pass_pošiljatelj.Size = new System.Drawing.Size(952, 20);
            this.pass_pošiljatelj.TabIndex = 7;
            this.pass_pošiljatelj.TextChanged += new System.EventHandler(this.pass_pošiljatelj_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1298, 783);
            this.Controls.Add(this.pass_pošiljatelj);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_poruka);
            this.Controls.Add(this.txt_naslov);
            this.Controls.Add(this.txt_primatelj);
            this.Controls.Add(this.txt_pošiljatelj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pošiljatelj;
        private System.Windows.Forms.TextBox txt_primatelj;
        private System.Windows.Forms.TextBox txt_naslov;
        private System.Windows.Forms.RichTextBox txt_poruka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox pass_pošiljatelj;
    }
}

