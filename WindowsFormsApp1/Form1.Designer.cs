namespace WindowsFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_fizetes = new System.Windows.Forms.TextBox();
            this.textBox_pozicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_frissit = new System.Windows.Forms.Button();
            this.button_uj = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button_torol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 290);
            this.listBox1.TabIndex = 0;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(230, 13);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(230, 59);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_nev.TabIndex = 2;
            // 
            // textBox_fizetes
            // 
            this.textBox_fizetes.Location = new System.Drawing.Point(230, 102);
            this.textBox_fizetes.Name = "textBox_fizetes";
            this.textBox_fizetes.Size = new System.Drawing.Size(100, 20);
            this.textBox_fizetes.TabIndex = 3;
            // 
            // textBox_pozicio
            // 
            this.textBox_pozicio.Location = new System.Drawing.Point(230, 144);
            this.textBox_pozicio.Name = "textBox_pozicio";
            this.textBox_pozicio.Size = new System.Drawing.Size(100, 20);
            this.textBox_pozicio.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fizetés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pozíció";
            // 
            // button_frissit
            // 
            this.button_frissit.Location = new System.Drawing.Point(230, 180);
            this.button_frissit.Name = "button_frissit";
            this.button_frissit.Size = new System.Drawing.Size(75, 23);
            this.button_frissit.TabIndex = 9;
            this.button_frissit.Text = "Frissít";
            this.button_frissit.UseVisualStyleBackColor = true;
            this.button_frissit.Click += new System.EventHandler(this.button_frissit_Click);
            // 
            // button_uj
            // 
            this.button_uj.Location = new System.Drawing.Point(230, 210);
            this.button_uj.Name = "button_uj";
            this.button_uj.Size = new System.Drawing.Size(75, 23);
            this.button_uj.TabIndex = 10;
            this.button_uj.Text = "Új";
            this.button_uj.UseVisualStyleBackColor = true;
            this.button_uj.Click += new System.EventHandler(this.button_uj_Click);
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(230, 240);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(75, 23);
            this.button_modosit.TabIndex = 11;
            this.button_modosit.Text = "Módosít";
            this.button_modosit.UseVisualStyleBackColor = true;
            this.button_modosit.Click += new System.EventHandler(this.button_modosit_Click);
            // 
            // button_torol
            // 
            this.button_torol.Location = new System.Drawing.Point(230, 270);
            this.button_torol.Name = "button_torol";
            this.button_torol.Size = new System.Drawing.Size(75, 23);
            this.button_torol.TabIndex = 12;
            this.button_torol.Text = "Töröl";
            this.button_torol.UseVisualStyleBackColor = true;
            this.button_torol.Click += new System.EventHandler(this.button_torol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 320);
            this.Controls.Add(this.button_torol);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.button_uj);
            this.Controls.Add(this.button_frissit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pozicio);
            this.Controls.Add(this.textBox_fizetes);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_fizetes;
        private System.Windows.Forms.TextBox textBox_pozicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_frissit;
        private System.Windows.Forms.Button button_uj;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_torol;
    }
}

