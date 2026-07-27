namespace Würfelspiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BoxSpieler1_Name = new System.Windows.Forms.TextBox();
            this.BoxSpieler2_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxPunkte_1 = new System.Windows.Forms.TextBox();
            this.BoxPunkte_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Würfel = new System.Windows.Forms.Button();
            this.BoxWürfel_2 = new System.Windows.Forms.TextBox();
            this.BoxWürfel_1 = new System.Windows.Forms.TextBox();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxSpieler1_Name
            // 
            this.BoxSpieler1_Name.Location = new System.Drawing.Point(12, 133);
            this.BoxSpieler1_Name.Name = "BoxSpieler1_Name";
            this.BoxSpieler1_Name.Size = new System.Drawing.Size(166, 20);
            this.BoxSpieler1_Name.TabIndex = 0;
            this.BoxSpieler1_Name.Text = "Name:";
            this.BoxSpieler1_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxSpieler1_Name.TextChanged += new System.EventHandler(this.BoxSpieler1_Name_TextChanged);
            // 
            // BoxSpieler2_Name
            // 
            this.BoxSpieler2_Name.Location = new System.Drawing.Point(221, 133);
            this.BoxSpieler2_Name.Name = "BoxSpieler2_Name";
            this.BoxSpieler2_Name.Size = new System.Drawing.Size(166, 20);
            this.BoxSpieler2_Name.TabIndex = 1;
            this.BoxSpieler2_Name.Text = "Name:";
            this.BoxSpieler2_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "Würfelspiel:\nJedes Spieler würfelt abwechselnd mit jweils 2 Würfel.\n" +
                "Der Spieler welcher zuerst 100 Punkte erreicht hat, gewinnt.\n" +
                "sWürfelt man einen Pasch verliert man all seine Punkte.\n" +
                "Würfelt man eine Zahl niedriger als 6 bekommt keine Punkte.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Punkte:";
            // 
            // BoxPunkte_1
            // 
            this.BoxPunkte_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPunkte_1.Location = new System.Drawing.Point(72, 180);
            this.BoxPunkte_1.Name = "BoxPunkte_1";
            this.BoxPunkte_1.ReadOnly = true;
            this.BoxPunkte_1.Size = new System.Drawing.Size(67, 44);
            this.BoxPunkte_1.TabIndex = 4;
            this.BoxPunkte_1.TabStop = false;
            this.BoxPunkte_1.Text = "0";
            this.BoxPunkte_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPunkte_2
            // 
            this.BoxPunkte_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPunkte_2.Location = new System.Drawing.Point(275, 180);
            this.BoxPunkte_2.Name = "BoxPunkte_2";
            this.BoxPunkte_2.ReadOnly = true;
            this.BoxPunkte_2.Size = new System.Drawing.Size(67, 44);
            this.BoxPunkte_2.TabIndex = 5;
            this.BoxPunkte_2.TabStop = false;
            this.BoxPunkte_2.Text = "0";
            this.BoxPunkte_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Punkte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Würfelt: Spieler 1";
            // 
            // Button_Würfel
            // 
            this.Button_Würfel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_Würfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Würfel.Location = new System.Drawing.Point(153, 270);
            this.Button_Würfel.Name = "Button_Würfel";
            this.Button_Würfel.Size = new System.Drawing.Size(94, 23);
            this.Button_Würfel.TabIndex = 8;
            this.Button_Würfel.Text = "WÜRFELN";
            this.Button_Würfel.UseVisualStyleBackColor = false;
            this.Button_Würfel.Click += new System.EventHandler(this.Button_Würfel_Click);
            // 
            // BoxWürfel_2
            // 
            this.BoxWürfel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BoxWürfel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxWürfel_2.Location = new System.Drawing.Point(221, 322);
            this.BoxWürfel_2.Name = "BoxWürfel_2";
            this.BoxWürfel_2.ReadOnly = true;
            this.BoxWürfel_2.Size = new System.Drawing.Size(67, 44);
            this.BoxWürfel_2.TabIndex = 9;
            this.BoxWürfel_2.TabStop = false;
            this.BoxWürfel_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxWürfel_1
            // 
            this.BoxWürfel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BoxWürfel_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxWürfel_1.Location = new System.Drawing.Point(111, 322);
            this.BoxWürfel_1.Name = "BoxWürfel_1";
            this.BoxWürfel_1.ReadOnly = true;
            this.BoxWürfel_1.Size = new System.Drawing.Size(67, 44);
            this.BoxWürfel_1.TabIndex = 11;
            this.BoxWürfel_1.TabStop = false;
            this.BoxWürfel_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_Reset
            // 
            this.Button_Reset.BackColor = System.Drawing.Color.Gray;
            this.Button_Reset.ForeColor = System.Drawing.Color.White;
            this.Button_Reset.Location = new System.Drawing.Point(15, 373);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(75, 23);
            this.Button_Reset.TabIndex = 12;
            this.Button_Reset.Text = "Neues Spiel";
            this.Button_Reset.UseVisualStyleBackColor = false;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Würfel 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Würfel 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Spieler 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Spieler 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 408);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.BoxWürfel_1);
            this.Controls.Add(this.BoxWürfel_2);
            this.Controls.Add(this.Button_Würfel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxPunkte_2);
            this.Controls.Add(this.BoxPunkte_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxSpieler2_Name);
            this.Controls.Add(this.BoxSpieler1_Name);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxSpieler1_Name;
        private System.Windows.Forms.TextBox BoxSpieler2_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxPunkte_1;
        private System.Windows.Forms.TextBox BoxPunkte_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Würfel;
        private System.Windows.Forms.TextBox BoxWürfel_2;
        private System.Windows.Forms.TextBox BoxWürfel_1;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

