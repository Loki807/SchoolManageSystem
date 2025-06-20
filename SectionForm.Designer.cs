namespace SchoolManageSystem
{
    partial class SectionForm
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
            this.txtName = new System.Windows.Forms.Label();
            this.secName = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.secSearch = new System.Windows.Forms.TextBox();
            this.dgvSections = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(207, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(74, 13);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Section Name";
            // 
            // secName
            // 
            this.secName.Location = new System.Drawing.Point(311, 83);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(240, 20);
            this.secName.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(476, 135);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(374, 135);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 3;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(283, 135);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(210, 182);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 5;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            // 
            // secSearch
            // 
            this.secSearch.Location = new System.Drawing.Point(311, 184);
            this.secSearch.Name = "secSearch";
            this.secSearch.Size = new System.Drawing.Size(240, 20);
            this.secSearch.TabIndex = 6;
            // 
            // dgvSections
            // 
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSections.Location = new System.Drawing.Point(210, 233);
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.Size = new System.Drawing.Size(341, 150);
            this.dgvSections.TabIndex = 7;
            this.dgvSections.SelectionChanged += new System.EventHandler(this.dgvSections_SelectionChanged);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSections);
            this.Controls.Add(this.secSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.secName);
            this.Controls.Add(this.txtName);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox secName;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox secSearch;
        private System.Windows.Forms.DataGridView dgvSections;
    }
}