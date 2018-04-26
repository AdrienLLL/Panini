namespace Panini
{
    partial class FormPanini
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
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.BtnAddSticker = new System.Windows.Forms.Button();
            this.BoxAddSticker = new System.Windows.Forms.TextBox();
            this.BtnAddDuplication = new System.Windows.Forms.Button();
            this.BtnDeleteSticker = new System.Windows.Forms.Button();
            this.BtnDeleteDuplication = new System.Windows.Forms.Button();
            this.BoxDeleteDoublon = new System.Windows.Forms.TextBox();
            this.BoxDeleteSticker = new System.Windows.Forms.TextBox();
            this.BoxAddDuplication = new System.Windows.Forms.TextBox();
            this.BtnCreateAlbum = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.BoxNumber = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDGV
            // 
            this.MainDGV.AccessibleName = "MainDGV";
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV.Location = new System.Drawing.Point(12, 12);
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.RowTemplate.Height = 24;
            this.MainDGV.Size = new System.Drawing.Size(665, 789);
            this.MainDGV.TabIndex = 0;
            // 
            // BtnAddSticker
            // 
            this.BtnAddSticker.AccessibleName = "AddSticker";
            this.BtnAddSticker.Location = new System.Drawing.Point(759, 18);
            this.BtnAddSticker.Name = "BtnAddSticker";
            this.BtnAddSticker.Size = new System.Drawing.Size(137, 29);
            this.BtnAddSticker.TabIndex = 1;
            this.BtnAddSticker.Text = "Add Sticker";
            this.BtnAddSticker.UseVisualStyleBackColor = true;
            // 
            // BoxAddSticker
            // 
            this.BoxAddSticker.AccessibleName = "BoxAddSticker";
            this.BoxAddSticker.Location = new System.Drawing.Point(902, 21);
            this.BoxAddSticker.Name = "BoxAddSticker";
            this.BoxAddSticker.Size = new System.Drawing.Size(452, 22);
            this.BoxAddSticker.TabIndex = 2;
            // 
            // BtnAddDuplication
            // 
            this.BtnAddDuplication.AccessibleName = "AddDuplication";
            this.BtnAddDuplication.Location = new System.Drawing.Point(759, 53);
            this.BtnAddDuplication.Name = "BtnAddDuplication";
            this.BtnAddDuplication.Size = new System.Drawing.Size(137, 29);
            this.BtnAddDuplication.TabIndex = 3;
            this.BtnAddDuplication.Text = "Add Duplication";
            this.BtnAddDuplication.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteSticker
            // 
            this.BtnDeleteSticker.AccessibleName = "DeleteSticker";
            this.BtnDeleteSticker.Location = new System.Drawing.Point(759, 88);
            this.BtnDeleteSticker.Name = "BtnDeleteSticker";
            this.BtnDeleteSticker.Size = new System.Drawing.Size(137, 29);
            this.BtnDeleteSticker.TabIndex = 4;
            this.BtnDeleteSticker.Text = "Delete Sticker";
            this.BtnDeleteSticker.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteDuplication
            // 
            this.BtnDeleteDuplication.AccessibleName = "DeleteDuplication";
            this.BtnDeleteDuplication.Location = new System.Drawing.Point(759, 123);
            this.BtnDeleteDuplication.Name = "BtnDeleteDuplication";
            this.BtnDeleteDuplication.Size = new System.Drawing.Size(137, 29);
            this.BtnDeleteDuplication.TabIndex = 5;
            this.BtnDeleteDuplication.Text = "Delete Duplication";
            this.BtnDeleteDuplication.UseVisualStyleBackColor = true;
            // 
            // BoxDeleteDoublon
            // 
            this.BoxDeleteDoublon.Location = new System.Drawing.Point(902, 126);
            this.BoxDeleteDoublon.Name = "BoxDeleteDoublon";
            this.BoxDeleteDoublon.Size = new System.Drawing.Size(452, 22);
            this.BoxDeleteDoublon.TabIndex = 6;
            // 
            // BoxDeleteSticker
            // 
            this.BoxDeleteSticker.AccessibleName = "BoxDeleteDuplication";
            this.BoxDeleteSticker.Location = new System.Drawing.Point(902, 91);
            this.BoxDeleteSticker.Name = "BoxDeleteSticker";
            this.BoxDeleteSticker.Size = new System.Drawing.Size(452, 22);
            this.BoxDeleteSticker.TabIndex = 7;
            // 
            // BoxAddDuplication
            // 
            this.BoxAddDuplication.AccessibleName = "BoxAddDuplication";
            this.BoxAddDuplication.Location = new System.Drawing.Point(902, 56);
            this.BoxAddDuplication.Name = "BoxAddDuplication";
            this.BoxAddDuplication.Size = new System.Drawing.Size(452, 22);
            this.BoxAddDuplication.TabIndex = 8;
            // 
            // BtnCreateAlbum
            // 
            this.BtnCreateAlbum.AccessibleName = "BtnCreateAlbum";
            this.BtnCreateAlbum.Location = new System.Drawing.Point(759, 337);
            this.BtnCreateAlbum.Name = "BtnCreateAlbum";
            this.BtnCreateAlbum.Size = new System.Drawing.Size(137, 29);
            this.BtnCreateAlbum.TabIndex = 9;
            this.BtnCreateAlbum.Text = "Create Album";
            this.BtnCreateAlbum.UseVisualStyleBackColor = true;
            // 
            // LblName
            // 
            this.LblName.AccessibleName = "LblName";
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(1054, 347);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(61, 17);
            this.LblName.TabIndex = 10;
            this.LblName.Text = " Name : ";
            // 
            // LblNumber
            // 
            this.LblNumber.AccessibleName = "LblNumber";
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(977, 385);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(134, 17);
            this.LblNumber.TabIndex = 11;
            this.LblNumber.Text = "Number of stickers :";
            // 
            // BoxNumber
            // 
            this.BoxNumber.AccessibleName = "BoxNumber";
            this.BoxNumber.Location = new System.Drawing.Point(1117, 382);
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.Size = new System.Drawing.Size(237, 22);
            this.BoxNumber.TabIndex = 12;
            // 
            // BoxName
            // 
            this.BoxName.AccessibleName = "BoxName";
            this.BoxName.Location = new System.Drawing.Point(1117, 344);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(237, 22);
            this.BoxName.TabIndex = 13;
            // 
            // FormPanini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 813);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.BoxNumber);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnCreateAlbum);
            this.Controls.Add(this.BoxAddDuplication);
            this.Controls.Add(this.BoxDeleteSticker);
            this.Controls.Add(this.BoxDeleteDoublon);
            this.Controls.Add(this.BtnDeleteDuplication);
            this.Controls.Add(this.BtnDeleteSticker);
            this.Controls.Add(this.BtnAddDuplication);
            this.Controls.Add(this.BoxAddSticker);
            this.Controls.Add(this.BtnAddSticker);
            this.Controls.Add(this.MainDGV);
            this.Name = "FormPanini";
            this.Text = "Panini";
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDGV;
        private System.Windows.Forms.Button BtnAddSticker;
        private System.Windows.Forms.TextBox BoxAddSticker;
        private System.Windows.Forms.Button BtnAddDuplication;
        private System.Windows.Forms.Button BtnDeleteSticker;
        private System.Windows.Forms.Button BtnDeleteDuplication;
        private System.Windows.Forms.TextBox BoxDeleteDoublon;
        private System.Windows.Forms.TextBox BoxDeleteSticker;
        private System.Windows.Forms.TextBox BoxAddDuplication;
        private System.Windows.Forms.Button BtnCreateAlbum;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.TextBox BoxNumber;
        private System.Windows.Forms.TextBox BoxName;
    }
}

