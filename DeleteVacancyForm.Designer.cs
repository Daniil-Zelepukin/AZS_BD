namespace AZS_BD
{
    partial class DeleteVacancyForm
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
            this.components = new System.ComponentModel.Container();
            this.titleslabel = new System.Windows.Forms.Label();
            this.vacancyCB = new System.Windows.Forms.ComboBox();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detelebutton = new System.Windows.Forms.Button();
            this.clousebutton = new System.Windows.Forms.Button();
            this.workers_AZS_BDDataSet = new AZS_BD.Workers_AZS_BDDataSet();
            this.titlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titlesTableAdapter = new AZS_BD.Workers_AZS_BDDataSetTableAdapters.TitlesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers_AZS_BDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleslabel
            // 
            this.titleslabel.AutoSize = true;
            this.titleslabel.Location = new System.Drawing.Point(12, 9);
            this.titleslabel.Name = "titleslabel";
            this.titleslabel.Size = new System.Drawing.Size(51, 16);
            this.titleslabel.TabIndex = 0;
            this.titleslabel.Text = "Отдел:";
            // 
            // vacancyCB
            // 
            this.vacancyCB.DataSource = this.titlesBindingSource1;
            this.vacancyCB.DisplayMember = "Titles";
            this.vacancyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vacancyCB.FormattingEnabled = true;
            this.vacancyCB.Location = new System.Drawing.Point(15, 28);
            this.vacancyCB.Name = "vacancyCB";
            this.vacancyCB.Size = new System.Drawing.Size(298, 24);
            this.vacancyCB.TabIndex = 1;
            this.vacancyCB.ValueMember = "ID";
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "Titles";
            // 
            // detelebutton
            // 
            this.detelebutton.Location = new System.Drawing.Point(15, 58);
            this.detelebutton.Name = "detelebutton";
            this.detelebutton.Size = new System.Drawing.Size(298, 33);
            this.detelebutton.TabIndex = 2;
            this.detelebutton.Text = "Удалить";
            this.detelebutton.UseVisualStyleBackColor = true;
            this.detelebutton.Click += new System.EventHandler(this.detelebutton_Click);
            // 
            // clousebutton
            // 
            this.clousebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.clousebutton.Location = new System.Drawing.Point(122, 108);
            this.clousebutton.Name = "clousebutton";
            this.clousebutton.Size = new System.Drawing.Size(94, 33);
            this.clousebutton.TabIndex = 4;
            this.clousebutton.Text = "Закрыть";
            this.clousebutton.UseVisualStyleBackColor = true;
            // 
            // workers_AZS_BDDataSet
            // 
            this.workers_AZS_BDDataSet.DataSetName = "Workers_AZS_BDDataSet";
            this.workers_AZS_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titlesBindingSource1
            // 
            this.titlesBindingSource1.DataMember = "Titles";
            this.titlesBindingSource1.DataSource = this.workers_AZS_BDDataSet;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 153);
            this.Controls.Add(this.clousebutton);
            this.Controls.Add(this.detelebutton);
            this.Controls.Add(this.vacancyCB);
            this.Controls.Add(this.titleslabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(345, 200);
            this.MinimumSize = new System.Drawing.Size(345, 200);
            this.Name = "DeleteVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить вакансию";
            this.Load += new System.EventHandler(this.DeleteVacancyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers_AZS_BDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleslabel;
        private System.Windows.Forms.ComboBox vacancyCB;
        private System.Windows.Forms.Button detelebutton;
        
        private System.Windows.Forms.BindingSource titlesBindingSource;
        
        private System.Windows.Forms.Button clousebutton;
        private Workers_AZS_BDDataSet workers_AZS_BDDataSet;
        private System.Windows.Forms.BindingSource titlesBindingSource1;
        private Workers_AZS_BDDataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
    }
}