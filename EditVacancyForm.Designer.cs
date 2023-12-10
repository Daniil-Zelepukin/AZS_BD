namespace AZS_BD
{
    partial class EditVacancyForm
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
            this.vacancylabel = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.titlestextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vacancylabel
            // 
            this.vacancylabel.AutoSize = true;
            this.vacancylabel.Location = new System.Drawing.Point(13, 13);
            this.vacancylabel.Name = "vacancylabel";
            this.vacancylabel.Size = new System.Drawing.Size(72, 16);
            this.vacancylabel.TabIndex = 0;
            this.vacancylabel.Text = "Вакансия:";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(33, 80);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(96, 33);
            this.savebutton.TabIndex = 1;
            this.savebutton.Text = "Сохранить";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(173, 80);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(96, 33);
            this.cancelbutton.TabIndex = 2;
            this.cancelbutton.Text = "Отмена";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // titlestextBox
            // 
            this.titlestextBox.Location = new System.Drawing.Point(16, 42);
            this.titlestextBox.Name = "titlestextBox";
            this.titlestextBox.Size = new System.Drawing.Size(283, 22);
            this.titlestextBox.TabIndex = 3;
            // 
            // EditVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 133);
            this.Controls.Add(this.titlestextBox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.vacancylabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(350, 180);
            this.MinimumSize = new System.Drawing.Size(350, 180);
            this.Name = "EditVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить вакансию";
            this.Load += new System.EventHandler(this.EditVacancyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vacancylabel;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.TextBox titlestextBox;
    }
}