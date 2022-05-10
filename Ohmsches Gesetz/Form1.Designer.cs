namespace Ohmsches_Gesetz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_wert2 = new System.Windows.Forms.TextBox();
            this.tB_wert1 = new System.Windows.Forms.TextBox();
            this.dlbl_wert2 = new System.Windows.Forms.Label();
            this.dlbl_wert1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rB_spannung = new System.Windows.Forms.RadioButton();
            this.rb_strom = new System.Windows.Forms.RadioButton();
            this.rB_widerstand = new System.Windows.Forms.RadioButton();
            this.btn_Berechnen = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_wert2);
            this.groupBox1.Controls.Add(this.tB_wert1);
            this.groupBox1.Controls.Add(this.dlbl_wert2);
            this.groupBox1.Controls.Add(this.dlbl_wert1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            // 
            // tB_wert2
            // 
            this.tB_wert2.Location = new System.Drawing.Point(139, 33);
            this.tB_wert2.Name = "tB_wert2";
            this.tB_wert2.Size = new System.Drawing.Size(100, 20);
            this.tB_wert2.TabIndex = 2;
            // 
            // tB_wert1
            // 
            this.tB_wert1.Location = new System.Drawing.Point(9, 33);
            this.tB_wert1.Name = "tB_wert1";
            this.tB_wert1.Size = new System.Drawing.Size(100, 20);
            this.tB_wert1.TabIndex = 1;
            // 
            // dlbl_wert2
            // 
            this.dlbl_wert2.AutoSize = true;
            this.dlbl_wert2.Location = new System.Drawing.Point(136, 16);
            this.dlbl_wert2.Name = "dlbl_wert2";
            this.dlbl_wert2.Size = new System.Drawing.Size(46, 13);
            this.dlbl_wert2.TabIndex = 0;
            this.dlbl_wert2.Text = "Strom [I]";
            // 
            // dlbl_wert1
            // 
            this.dlbl_wert1.AutoSize = true;
            this.dlbl_wert1.Location = new System.Drawing.Point(6, 17);
            this.dlbl_wert1.Name = "dlbl_wert1";
            this.dlbl_wert1.Size = new System.Drawing.Size(73, 13);
            this.dlbl_wert1.TabIndex = 0;
            this.dlbl_wert1.Text = "Spannung [U]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rB_spannung);
            this.groupBox2.Controls.Add(this.rb_strom);
            this.groupBox2.Controls.Add(this.rB_widerstand);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Berechnungen";
            // 
            // rB_spannung
            // 
            this.rB_spannung.AutoSize = true;
            this.rB_spannung.Location = new System.Drawing.Point(178, 19);
            this.rB_spannung.Name = "rB_spannung";
            this.rB_spannung.Size = new System.Drawing.Size(91, 17);
            this.rB_spannung.TabIndex = 0;
            this.rB_spannung.Text = "Spannung [U]";
            this.rB_spannung.UseVisualStyleBackColor = true;
            this.rB_spannung.CheckedChanged += new System.EventHandler(this.rbChanged);
            // 
            // rb_strom
            // 
            this.rb_strom.AutoSize = true;
            this.rb_strom.Location = new System.Drawing.Point(108, 19);
            this.rb_strom.Name = "rb_strom";
            this.rb_strom.Size = new System.Drawing.Size(64, 17);
            this.rb_strom.TabIndex = 0;
            this.rb_strom.Text = "Strom [I]";
            this.rb_strom.UseVisualStyleBackColor = true;
            this.rb_strom.CheckedChanged += new System.EventHandler(this.rbChanged);
            // 
            // rB_widerstand
            // 
            this.rB_widerstand.AutoSize = true;
            this.rB_widerstand.Checked = true;
            this.rB_widerstand.Location = new System.Drawing.Point(6, 19);
            this.rB_widerstand.Name = "rB_widerstand";
            this.rB_widerstand.Size = new System.Drawing.Size(96, 17);
            this.rB_widerstand.TabIndex = 0;
            this.rB_widerstand.TabStop = true;
            this.rB_widerstand.Text = "Widerstand [R]";
            this.rB_widerstand.UseVisualStyleBackColor = true;
            this.rB_widerstand.CheckedChanged += new System.EventHandler(this.rbChanged);
            // 
            // btn_Berechnen
            // 
            this.btn_Berechnen.Location = new System.Drawing.Point(293, 19);
            this.btn_Berechnen.Name = "btn_Berechnen";
            this.btn_Berechnen.Size = new System.Drawing.Size(75, 23);
            this.btn_Berechnen.TabIndex = 1;
            this.btn_Berechnen.Text = "Berechnen";
            this.btn_Berechnen.UseVisualStyleBackColor = true;
            this.btn_Berechnen.Click += new System.EventHandler(this.btn_Berechnen_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(293, 45);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Beenden";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 156);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Berechnen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ohmsches Gesetz | Sebastian Schindler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_wert2;
        private System.Windows.Forms.TextBox tB_wert1;
        private System.Windows.Forms.Label dlbl_wert2;
        private System.Windows.Forms.Label dlbl_wert1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rB_spannung;
        private System.Windows.Forms.RadioButton rb_strom;
        private System.Windows.Forms.RadioButton rB_widerstand;
        private System.Windows.Forms.Button btn_Berechnen;
        private System.Windows.Forms.Button btn_exit;
    }
}

