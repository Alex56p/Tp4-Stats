namespace TP4_Stats
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Moyenne = new System.Windows.Forms.TextBox();
            this.TB_EcartType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RB_1 = new System.Windows.Forms.RadioButton();
            this.Cas = new System.Windows.Forms.GroupBox();
            this.RB_3 = new System.Windows.Forms.RadioButton();
            this.RB_2 = new System.Windows.Forms.RadioButton();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.TB_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Resultat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Effacer = new System.Windows.Forms.Button();
            this.BTN_Aide = new System.Windows.Forms.Button();
            this.Cas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Moyenne
            // 
            this.TB_Moyenne.Location = new System.Drawing.Point(83, 13);
            this.TB_Moyenne.Name = "TB_Moyenne";
            this.TB_Moyenne.Size = new System.Drawing.Size(100, 20);
            this.TB_Moyenne.TabIndex = 0;
            this.TB_Moyenne.Text = "60";
            // 
            // TB_EcartType
            // 
            this.TB_EcartType.Location = new System.Drawing.Point(83, 39);
            this.TB_EcartType.Name = "TB_EcartType";
            this.TB_EcartType.Size = new System.Drawing.Size(100, 20);
            this.TB_EcartType.TabIndex = 1;
            this.TB_EcartType.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moyenne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Écart Type :";
            // 
            // RB_1
            // 
            this.RB_1.AutoSize = true;
            this.RB_1.Checked = true;
            this.RB_1.Location = new System.Drawing.Point(18, 19);
            this.RB_1.Name = "RB_1";
            this.RB_1.Size = new System.Drawing.Size(81, 17);
            this.RB_1.TabIndex = 4;
            this.RB_1.TabStop = true;
            this.RB_1.Text = "P(a < X < b)";
            this.RB_1.UseVisualStyleBackColor = true;
            this.RB_1.CheckedChanged += new System.EventHandler(this.RB_1_CheckedChanged);
            // 
            // Cas
            // 
            this.Cas.Controls.Add(this.RB_3);
            this.Cas.Controls.Add(this.RB_2);
            this.Cas.Controls.Add(this.RB_1);
            this.Cas.Location = new System.Drawing.Point(15, 119);
            this.Cas.Name = "Cas";
            this.Cas.Size = new System.Drawing.Size(168, 102);
            this.Cas.TabIndex = 5;
            this.Cas.TabStop = false;
            this.Cas.Text = "Cas";
            // 
            // RB_3
            // 
            this.RB_3.AutoSize = true;
            this.RB_3.Location = new System.Drawing.Point(18, 65);
            this.RB_3.Name = "RB_3";
            this.RB_3.Size = new System.Drawing.Size(63, 17);
            this.RB_3.TabIndex = 6;
            this.RB_3.Text = "P(X > a)";
            this.RB_3.UseVisualStyleBackColor = true;
            this.RB_3.CheckedChanged += new System.EventHandler(this.RB_3_CheckedChanged);
            // 
            // RB_2
            // 
            this.RB_2.AutoSize = true;
            this.RB_2.Location = new System.Drawing.Point(18, 42);
            this.RB_2.Name = "RB_2";
            this.RB_2.Size = new System.Drawing.Size(63, 17);
            this.RB_2.TabIndex = 5;
            this.RB_2.Text = "P(X < a)";
            this.RB_2.UseVisualStyleBackColor = true;
            this.RB_2.CheckedChanged += new System.EventHandler(this.RB_2_CheckedChanged);
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Location = new System.Drawing.Point(63, 293);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(120, 23);
            this.BTN_Calculer.TabIndex = 6;
            this.BTN_Calculer.Text = "Calculer la probabilité";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // TB_a
            // 
            this.TB_a.Location = new System.Drawing.Point(83, 65);
            this.TB_a.Name = "TB_a";
            this.TB_a.Size = new System.Drawing.Size(100, 20);
            this.TB_a.TabIndex = 2;
            this.TB_a.Text = "40";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "a :";
            // 
            // TB_b
            // 
            this.TB_b.Location = new System.Drawing.Point(83, 91);
            this.TB_b.Name = "TB_b";
            this.TB_b.Size = new System.Drawing.Size(100, 20);
            this.TB_b.TabIndex = 3;
            this.TB_b.Text = "65";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "b :";
            // 
            // TB_Resultat
            // 
            this.TB_Resultat.Location = new System.Drawing.Point(83, 227);
            this.TB_Resultat.Name = "TB_Resultat";
            this.TB_Resultat.ReadOnly = true;
            this.TB_Resultat.Size = new System.Drawing.Size(100, 20);
            this.TB_Resultat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Résultat :";
            // 
            // BTN_Effacer
            // 
            this.BTN_Effacer.Location = new System.Drawing.Point(63, 264);
            this.BTN_Effacer.Name = "BTN_Effacer";
            this.BTN_Effacer.Size = new System.Drawing.Size(120, 23);
            this.BTN_Effacer.TabIndex = 13;
            this.BTN_Effacer.Text = "Effacer";
            this.BTN_Effacer.UseVisualStyleBackColor = true;
            this.BTN_Effacer.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // BTN_Aide
            // 
            this.BTN_Aide.Location = new System.Drawing.Point(5, 293);
            this.BTN_Aide.Name = "BTN_Aide";
            this.BTN_Aide.Size = new System.Drawing.Size(52, 23);
            this.BTN_Aide.TabIndex = 14;
            this.BTN_Aide.Text = "Aide";
            this.BTN_Aide.UseVisualStyleBackColor = true;
            this.BTN_Aide.Click += new System.EventHandler(this.BTN_Aide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 328);
            this.Controls.Add(this.BTN_Aide);
            this.Controls.Add(this.BTN_Effacer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Resultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_a);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.Cas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_EcartType);
            this.Controls.Add(this.TB_Moyenne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Cas.ResumeLayout(false);
            this.Cas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Moyenne;
        private System.Windows.Forms.TextBox TB_EcartType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RB_1;
        private System.Windows.Forms.GroupBox Cas;
        private System.Windows.Forms.RadioButton RB_3;
        private System.Windows.Forms.RadioButton RB_2;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.TextBox TB_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Resultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Effacer;
        private System.Windows.Forms.Button BTN_Aide;
    }
}

