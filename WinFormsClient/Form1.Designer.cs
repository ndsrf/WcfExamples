namespace WinFormsClient
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.txtPar11 = new System.Windows.Forms.TextBox();
            this.txtPar21 = new System.Windows.Forms.TextBox();
            this.txtPar12 = new System.Windows.Forms.TextBox();
            this.txtPar22 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRes1 = new System.Windows.Forms.TextBox();
            this.txtRes2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(41, 210);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(141, 210);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 23);
            this.btnRestar.TabIndex = 1;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // txtPar11
            // 
            this.txtPar11.Location = new System.Drawing.Point(57, 23);
            this.txtPar11.Name = "txtPar11";
            this.txtPar11.Size = new System.Drawing.Size(100, 20);
            this.txtPar11.TabIndex = 2;
            // 
            // txtPar21
            // 
            this.txtPar21.Location = new System.Drawing.Point(57, 67);
            this.txtPar21.Name = "txtPar21";
            this.txtPar21.Size = new System.Drawing.Size(100, 20);
            this.txtPar21.TabIndex = 3;
            // 
            // txtPar12
            // 
            this.txtPar12.Location = new System.Drawing.Point(163, 23);
            this.txtPar12.Name = "txtPar12";
            this.txtPar12.Size = new System.Drawing.Size(100, 20);
            this.txtPar12.TabIndex = 4;
            // 
            // txtPar22
            // 
            this.txtPar22.Location = new System.Drawing.Point(163, 67);
            this.txtPar22.Name = "txtPar22";
            this.txtPar22.Size = new System.Drawing.Size(100, 20);
            this.txtPar22.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Par 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Par 2";
            // 
            // txtRes1
            // 
            this.txtRes1.Enabled = false;
            this.txtRes1.Location = new System.Drawing.Point(57, 140);
            this.txtRes1.Name = "txtRes1";
            this.txtRes1.Size = new System.Drawing.Size(100, 20);
            this.txtRes1.TabIndex = 8;
            // 
            // txtRes2
            // 
            this.txtRes2.Enabled = false;
            this.txtRes2.Location = new System.Drawing.Point(163, 140);
            this.txtRes2.Name = "txtRes2";
            this.txtRes2.Size = new System.Drawing.Size(100, 20);
            this.txtRes2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtRes2);
            this.Controls.Add(this.txtRes1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPar22);
            this.Controls.Add(this.txtPar12);
            this.Controls.Add(this.txtPar21);
            this.Controls.Add(this.txtPar11);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.TextBox txtPar11;
        private System.Windows.Forms.TextBox txtPar21;
        private System.Windows.Forms.TextBox txtPar12;
        private System.Windows.Forms.TextBox txtPar22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRes1;
        private System.Windows.Forms.TextBox txtRes2;
    }
}

