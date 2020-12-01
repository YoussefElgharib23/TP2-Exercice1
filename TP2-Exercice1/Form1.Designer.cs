
namespace TP2_Exercice1
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
            this.listBoxStagiaires = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.textBoxTelModifier = new System.Windows.Forms.TextBox();
            this.textBoxNumModifier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumSup = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxStagiaires
            // 
            this.listBoxStagiaires.FormattingEnabled = true;
            this.listBoxStagiaires.ItemHeight = 16;
            this.listBoxStagiaires.Location = new System.Drawing.Point(12, 12);
            this.listBoxStagiaires.Name = "listBoxStagiaires";
            this.listBoxStagiaires.Size = new System.Drawing.Size(613, 292);
            this.listBoxStagiaires.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTel);
            this.groupBox1.Controls.Add(this.textBoxPrenom);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.textBoxNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(242, 86);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(107, 26);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouterClickEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero:";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(444, 49);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(136, 22);
            this.textBoxTel.TabIndex = 4;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(113, 49);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(136, 22);
            this.textBoxPrenom.TabIndex = 2;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(444, 21);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(136, 22);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(113, 21);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(136, 22);
            this.textBoxNum.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.textBoxTelModifier);
            this.groupBox2.Controls.Add(this.textBoxNumModifier);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modification";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(242, 56);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(107, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifierClickEvent);
            // 
            // textBoxTelModifier
            // 
            this.textBoxTelModifier.Location = new System.Drawing.Point(444, 21);
            this.textBoxTelModifier.Name = "textBoxTelModifier";
            this.textBoxTelModifier.Size = new System.Drawing.Size(136, 22);
            this.textBoxTelModifier.TabIndex = 7;
            // 
            // textBoxNumModifier
            // 
            this.textBoxNumModifier.Location = new System.Drawing.Point(113, 21);
            this.textBoxNumModifier.Name = "textBoxNumModifier";
            this.textBoxNumModifier.Size = new System.Drawing.Size(136, 22);
            this.textBoxNumModifier.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telephone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numero:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSupprimer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxNumSup);
            this.groupBox3.Location = new System.Drawing.Point(12, 540);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 68);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suppression";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(412, 21);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 23);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimerClickEvent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Numero: ";
            // 
            // textBoxNumSup
            // 
            this.textBoxNumSup.Location = new System.Drawing.Point(173, 21);
            this.textBoxNumSup.Name = "textBoxNumSup";
            this.textBoxNumSup.Size = new System.Drawing.Size(219, 22);
            this.textBoxNumSup.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxStagiaires);
            this.Name = "Form1";
            this.Text = "Exercice 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosingEvent);
            this.Load += new System.EventHandler(this.formLoadEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStagiaires;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox textBoxTelModifier;
        private System.Windows.Forms.TextBox textBoxNumModifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumSup;
    }
}

