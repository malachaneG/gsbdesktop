
namespace gsbcompta
{
    partial class buttonAddUser
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
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.groupBoxFixedFees = new System.Windows.Forms.GroupBox();
            this.buttonFixedFeesUpdate = new System.Windows.Forms.Button();
            this.labelFixedFeesREP = new System.Windows.Forms.Label();
            this.labelFixedFeesNUI = new System.Windows.Forms.Label();
            this.labelFixedFeesKM = new System.Windows.Forms.Label();
            this.textBoxFixedFeesREP = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesNUI = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesKM = new System.Windows.Forms.TextBox();
            this.groupBoxOffPrice = new System.Windows.Forms.GroupBox();
            this.dataGridViewOffPrice = new System.Windows.Forms.DataGridView();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonValidationFiche = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.groupBoxFixedFees.SuspendLayout();
            this.groupBoxOffPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBills.MultiSelect = false;
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.RowHeadersWidth = 51;
            this.dataGridViewBills.RowTemplate.Height = 24;
            this.dataGridViewBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBills.Size = new System.Drawing.Size(829, 376);
            this.dataGridViewBills.TabIndex = 0;
            this.dataGridViewBills.SelectionChanged += new System.EventHandler(this.dataGridViewBills_SelectionChanged);
            // 
            // groupBoxFixedFees
            // 
            this.groupBoxFixedFees.Controls.Add(this.buttonFixedFeesUpdate);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesKM);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesKM);
            this.groupBoxFixedFees.Location = new System.Drawing.Point(847, 42);
            this.groupBoxFixedFees.Name = "groupBoxFixedFees";
            this.groupBoxFixedFees.Size = new System.Drawing.Size(444, 132);
            this.groupBoxFixedFees.TabIndex = 1;
            this.groupBoxFixedFees.TabStop = false;
            this.groupBoxFixedFees.Text = "Frais Forfait";
            // 
            // buttonFixedFeesUpdate
            // 
            this.buttonFixedFeesUpdate.Location = new System.Drawing.Point(302, 83);
            this.buttonFixedFeesUpdate.Name = "buttonFixedFeesUpdate";
            this.buttonFixedFeesUpdate.Size = new System.Drawing.Size(90, 23);
            this.buttonFixedFeesUpdate.TabIndex = 6;
            this.buttonFixedFeesUpdate.Text = "Modifier";
            this.buttonFixedFeesUpdate.UseVisualStyleBackColor = true;
            this.buttonFixedFeesUpdate.Click += new System.EventHandler(this.buttonFixedFeesUpdate_Click);
            // 
            // labelFixedFeesREP
            // 
            this.labelFixedFeesREP.AutoSize = true;
            this.labelFixedFeesREP.Location = new System.Drawing.Point(31, 83);
            this.labelFixedFeesREP.Name = "labelFixedFeesREP";
            this.labelFixedFeesREP.Size = new System.Drawing.Size(49, 17);
            this.labelFixedFeesREP.TabIndex = 5;
            this.labelFixedFeesREP.Text = "Repas";
            // 
            // labelFixedFeesNUI
            // 
            this.labelFixedFeesNUI.AutoSize = true;
            this.labelFixedFeesNUI.Location = new System.Drawing.Point(250, 40);
            this.labelFixedFeesNUI.Name = "labelFixedFeesNUI";
            this.labelFixedFeesNUI.Size = new System.Drawing.Size(33, 17);
            this.labelFixedFeesNUI.TabIndex = 4;
            this.labelFixedFeesNUI.Text = "Nuit";
            // 
            // labelFixedFeesKM
            // 
            this.labelFixedFeesKM.AutoSize = true;
            this.labelFixedFeesKM.Location = new System.Drawing.Point(13, 38);
            this.labelFixedFeesKM.Name = "labelFixedFeesKM";
            this.labelFixedFeesKM.Size = new System.Drawing.Size(74, 17);
            this.labelFixedFeesKM.TabIndex = 3;
            this.labelFixedFeesKM.Text = "Kilomètres";
            // 
            // textBoxFixedFeesREP
            // 
            this.textBoxFixedFeesREP.Location = new System.Drawing.Point(93, 78);
            this.textBoxFixedFeesREP.Name = "textBoxFixedFeesREP";
            this.textBoxFixedFeesREP.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesREP.TabIndex = 2;
            // 
            // textBoxFixedFeesNUI
            // 
            this.textBoxFixedFeesNUI.Location = new System.Drawing.Point(302, 35);
            this.textBoxFixedFeesNUI.Name = "textBoxFixedFeesNUI";
            this.textBoxFixedFeesNUI.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesNUI.TabIndex = 1;
            // 
            // textBoxFixedFeesKM
            // 
            this.textBoxFixedFeesKM.Location = new System.Drawing.Point(93, 35);
            this.textBoxFixedFeesKM.Name = "textBoxFixedFeesKM";
            this.textBoxFixedFeesKM.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesKM.TabIndex = 0;
            // 
            // groupBoxOffPrice
            // 
            this.groupBoxOffPrice.Controls.Add(this.dataGridViewOffPrice);
            this.groupBoxOffPrice.Location = new System.Drawing.Point(847, 180);
            this.groupBoxOffPrice.Name = "groupBoxOffPrice";
            this.groupBoxOffPrice.Size = new System.Drawing.Size(444, 208);
            this.groupBoxOffPrice.TabIndex = 2;
            this.groupBoxOffPrice.TabStop = false;
            this.groupBoxOffPrice.Text = "Frais Hors Forfait";
            // 
            // dataGridViewOffPrice
            // 
            this.dataGridViewOffPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffPrice.Location = new System.Drawing.Point(16, 21);
            this.dataGridViewOffPrice.Name = "dataGridViewOffPrice";
            this.dataGridViewOffPrice.RowHeadersWidth = 51;
            this.dataGridViewOffPrice.RowTemplate.Height = 24;
            this.dataGridViewOffPrice.Size = new System.Drawing.Size(424, 187);
            this.dataGridViewOffPrice.TabIndex = 0;
            this.dataGridViewOffPrice.SelectionChanged += new System.EventHandler(this.dataGridViewOffPrice_SelectionChanged);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(102, 438);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(149, 30);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Déconnexion";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonValidationFiche
            // 
            this.buttonValidationFiche.Location = new System.Drawing.Point(1090, 556);
            this.buttonValidationFiche.Name = "buttonValidationFiche";
            this.buttonValidationFiche.Size = new System.Drawing.Size(75, 23);
            this.buttonValidationFiche.TabIndex = 4;
            this.buttonValidationFiche.Text = "Modifier";
            this.buttonValidationFiche.UseVisualStyleBackColor = true;
            this.buttonValidationFiche.Click += new System.EventHandler(this.buttonValidationFiche_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "CR",
            "VA ",
            "RB"});
            this.comboBoxState.Location = new System.Drawing.Point(1129, 501);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(67, 24);
            this.comboBoxState.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(954, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modifier l\'état de la fiche :";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(1146, 451);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(0, 17);
            this.labelEtat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1082, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Etat :";
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.Location = new System.Drawing.Point(644, 438);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(166, 30);
            this.buttonAddUsers.TabIndex = 9;
            this.buttonAddUsers.Text = "Ajouter un utilisateur";
            this.buttonAddUsers.UseVisualStyleBackColor = true;
            this.buttonAddUsers.Click += new System.EventHandler(this.buttonAddUsers_Click);
            // 
            // buttonAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 636);
            this.Controls.Add(this.buttonAddUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.buttonValidationFiche);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.groupBoxOffPrice);
            this.Controls.Add(this.groupBoxFixedFees);
            this.Controls.Add(this.dataGridViewBills);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "buttonAddUser";
            this.Text = "ListeFiches";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.groupBoxFixedFees.ResumeLayout(false);
            this.groupBoxFixedFees.PerformLayout();
            this.groupBoxOffPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.GroupBox groupBoxFixedFees;
        private System.Windows.Forms.TextBox textBoxFixedFeesKM;
        private System.Windows.Forms.GroupBox groupBoxOffPrice;
        private System.Windows.Forms.TextBox textBoxFixedFeesREP;
        private System.Windows.Forms.TextBox textBoxFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesREP;
        private System.Windows.Forms.Label labelFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesKM;
        private System.Windows.Forms.DataGridView dataGridViewOffPrice;
        private System.Windows.Forms.Button buttonFixedFeesUpdate;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonValidationFiche;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddUsers;
    }
}