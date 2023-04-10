namespace SharpReview
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
            this.SubjectDropDown = new System.Windows.Forms.ComboBox();
            this.CardsList = new System.Windows.Forms.ListBox();
            this.NewFlashCardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectDropDown
            // 
            this.SubjectDropDown.FormattingEnabled = true;
            this.SubjectDropDown.Location = new System.Drawing.Point(13, 13);
            this.SubjectDropDown.Name = "SubjectDropDown";
            this.SubjectDropDown.Size = new System.Drawing.Size(178, 21);
            this.SubjectDropDown.TabIndex = 0;
            this.SubjectDropDown.SelectedIndexChanged += new System.EventHandler(this.SubjectDropDown_SelectedIndexChanged);
            // 
            // CardsList
            // 
            this.CardsList.FormattingEnabled = true;
            this.CardsList.Location = new System.Drawing.Point(13, 51);
            this.CardsList.Name = "CardsList";
            this.CardsList.Size = new System.Drawing.Size(178, 472);
            this.CardsList.TabIndex = 1;
            // 
            // NewFlashCardButton
            // 
            this.NewFlashCardButton.Location = new System.Drawing.Point(11, 529);
            this.NewFlashCardButton.Name = "NewFlashCardButton";
            this.NewFlashCardButton.Size = new System.Drawing.Size(179, 26);
            this.NewFlashCardButton.TabIndex = 2;
            this.NewFlashCardButton.Text = "New Flash Card";
            this.NewFlashCardButton.UseVisualStyleBackColor = true;
            this.NewFlashCardButton.Click += new System.EventHandler(this.NewFlashCardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 559);
            this.Controls.Add(this.NewFlashCardButton);
            this.Controls.Add(this.CardsList);
            this.Controls.Add(this.SubjectDropDown);
            this.Name = "Form1";
            this.Text = "SharpReview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button NewFlashCardButton;

        #endregion

        private System.Windows.Forms.ComboBox SubjectDropDown;
        private System.Windows.Forms.ListBox CardsList;
    }
}

