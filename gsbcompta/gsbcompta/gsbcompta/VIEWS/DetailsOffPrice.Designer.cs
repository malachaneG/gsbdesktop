namespace gsbcompta.VIEWS
{
    partial class DetailsOffPrice
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
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelMontantOffPrice = new System.Windows.Forms.Label();
            this.labelDateOffPrice = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(114, 203);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxAmount.TabIndex = 0;
            // 
            // labelMontantOffPrice
            // 
            this.labelMontantOffPrice.AutoSize = true;
            this.labelMontantOffPrice.Location = new System.Drawing.Point(25, 208);
            this.labelMontantOffPrice.Name = "labelMontantOffPrice";
            this.labelMontantOffPrice.Size = new System.Drawing.Size(67, 17);
            this.labelMontantOffPrice.TabIndex = 1;
            this.labelMontantOffPrice.Text = "Montant :";
            // 
            // labelDateOffPrice
            // 
            this.labelDateOffPrice.AutoSize = true;
            this.labelDateOffPrice.Location = new System.Drawing.Point(25, 169);
            this.labelDateOffPrice.Name = "labelDateOffPrice";
            this.labelDateOffPrice.Size = new System.Drawing.Size(46, 17);
            this.labelDateOffPrice.TabIndex = 2;
            this.labelDateOffPrice.Text = "Date :";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(114, 51);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(200, 22);
            this.textBoxUser.TabIndex = 5;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(25, 51);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(83, 17);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "Utilisateur : ";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(114, 89);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.ReadOnly = true;
            this.textBoxMonth.Size = new System.Drawing.Size(200, 22);
            this.textBoxMonth.TabIndex = 7;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(25, 89);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(45, 17);
            this.labelMonth.TabIndex = 6;
            this.labelMonth.Text = "Mois :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(114, 125);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Libelle : ";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(25, 249);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(78, 17);
            this.labelFile.TabIndex = 11;
            this.labelFile.Text = "Justificatif :";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(114, 244);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(200, 22);
            this.textBoxFile.TabIndex = 10;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 317);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(242, 38);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Enregistrer";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(114, 169);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 13;
            // 
            // DetailsOffPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 383);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelDateOffPrice);
            this.Controls.Add(this.labelMontantOffPrice);
            this.Controls.Add(this.textBoxAmount);
            this.Name = "DetailsOffPrice";
            this.Text = "DetailsOffPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelMontantOffPrice;
        private System.Windows.Forms.Label labelDateOffPrice;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}