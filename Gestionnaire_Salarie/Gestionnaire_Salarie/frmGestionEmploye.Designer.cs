namespace Gestionnaire_Employe
{
    partial class GestionEmploye
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdl1 = new System.Windows.Forms.TextBox();
            this.textBoxAdl2 = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxNoSecu = new System.Windows.Forms.TextBox();
            this.comboBoxCiv = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(1231, 421);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(114, 23);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Rafraichir";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_rafraichir_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(1231, 450);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(114, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 352);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(75, 12);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(75, 39);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBoxAdl1
            // 
            this.textBoxAdl1.Location = new System.Drawing.Point(75, 99);
            this.textBoxAdl1.Name = "textBoxAdl1";
            this.textBoxAdl1.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdl1.TabIndex = 7;
            // 
            // textBoxAdl2
            // 
            this.textBoxAdl2.Location = new System.Drawing.Point(358, 13);
            this.textBoxAdl2.Name = "textBoxAdl2";
            this.textBoxAdl2.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdl2.TabIndex = 8;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(358, 43);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(100, 22);
            this.textBoxCP.TabIndex = 9;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(358, 71);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 22);
            this.textBoxVille.TabIndex = 10;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(358, 99);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 22);
            this.textBoxTel.TabIndex = 11;
            // 
            // textBoxNoSecu
            // 
            this.textBoxNoSecu.Location = new System.Drawing.Point(358, 125);
            this.textBoxNoSecu.Name = "textBoxNoSecu";
            this.textBoxNoSecu.Size = new System.Drawing.Size(100, 22);
            this.textBoxNoSecu.TabIndex = 12;
            // 
            // comboBoxCiv
            // 
            this.comboBoxCiv.FormattingEnabled = true;
            this.comboBoxCiv.Location = new System.Drawing.Point(527, 41);
            this.comboBoxCiv.Name = "comboBoxCiv";
            this.comboBoxCiv.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCiv.TabIndex = 14;
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.Location = new System.Drawing.Point(1231, 479);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(114, 23);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Modifier";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(1231, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // GestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 543);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.comboBoxCiv);
            this.Controls.Add(this.textBoxNoSecu);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxAdl2);
            this.Controls.Add(this.textBoxAdl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.btn_refresh);
            this.Name = "GestionEmploye";
            this.Text = "Gestion Employe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxAdl1;
        private System.Windows.Forms.TextBox textBoxAdl2;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxNoSecu;
        private System.Windows.Forms.ComboBox comboBoxCiv;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button4;
    }
}

