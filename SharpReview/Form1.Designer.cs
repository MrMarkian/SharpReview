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
            this.refreshButton = new System.Windows.Forms.Button();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFlashCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerInputBox = new System.Windows.Forms.TextBox();
            this.CheckAnswerButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectDropDown
            // 
            this.SubjectDropDown.FormattingEnabled = true;
            this.SubjectDropDown.Location = new System.Drawing.Point(10, 63);
            this.SubjectDropDown.Name = "SubjectDropDown";
            this.SubjectDropDown.Size = new System.Drawing.Size(178, 21);
            this.SubjectDropDown.TabIndex = 0;
            this.SubjectDropDown.SelectedIndexChanged += new System.EventHandler(this.SubjectDropDown_SelectedIndexChanged);
            // 
            // CardsList
            // 
            this.CardsList.FormattingEnabled = true;
            this.CardsList.Location = new System.Drawing.Point(11, 94);
            this.CardsList.Name = "CardsList";
            this.CardsList.Size = new System.Drawing.Size(178, 446);
            this.CardsList.TabIndex = 1;
            this.CardsList.SelectedIndexChanged += new System.EventHandler(this.CardsList_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(211, 58);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(161, 26);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Location = new System.Drawing.Point(11, 40);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(80, 19);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "Subject";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.newFlashCardToolStripMenuItem, this.saveFlashCardsToolStripMenuItem, this.toolStripSeparator1, this.refreshFlashCardsToolStripMenuItem, this.toolStripSeparator2, this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFlashCardToolStripMenuItem
            // 
            this.newFlashCardToolStripMenuItem.Name = "newFlashCardToolStripMenuItem";
            this.newFlashCardToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newFlashCardToolStripMenuItem.Text = "New FlashCard";
            this.newFlashCardToolStripMenuItem.Click += new System.EventHandler(this.newFlashCardToolStripMenuItem_Click);
            // 
            // saveFlashCardsToolStripMenuItem
            // 
            this.saveFlashCardsToolStripMenuItem.Name = "saveFlashCardsToolStripMenuItem";
            this.saveFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveFlashCardsToolStripMenuItem.Text = "Save FlashCards";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // refreshFlashCardsToolStripMenuItem
            // 
            this.refreshFlashCardsToolStripMenuItem.Name = "refreshFlashCardsToolStripMenuItem";
            this.refreshFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.refreshFlashCardsToolStripMenuItem.Text = "Refresh FlashCards";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Location = new System.Drawing.Point(214, 100);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(312, 115);
            this.QuestionLabel.TabIndex = 6;
            this.QuestionLabel.Text = "Question";
            // 
            // AnswerInputBox
            // 
            this.AnswerInputBox.Location = new System.Drawing.Point(211, 383);
            this.AnswerInputBox.Name = "AnswerInputBox";
            this.AnswerInputBox.Size = new System.Drawing.Size(301, 20);
            this.AnswerInputBox.TabIndex = 7;
            // 
            // CheckAnswerButton
            // 
            this.CheckAnswerButton.Location = new System.Drawing.Point(405, 436);
            this.CheckAnswerButton.Name = "CheckAnswerButton";
            this.CheckAnswerButton.Size = new System.Drawing.Size(107, 27);
            this.CheckAnswerButton.TabIndex = 8;
            this.CheckAnswerButton.Text = "Check Answer";
            this.CheckAnswerButton.UseVisualStyleBackColor = true;
            this.CheckAnswerButton.Click += new System.EventHandler(this.CheckAnswerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 559);
            this.Controls.Add(this.CheckAnswerButton);
            this.Controls.Add(this.AnswerInputBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.CardsList);
            this.Controls.Add(this.SubjectDropDown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SharpReview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox AnswerInputBox;
        private System.Windows.Forms.Button CheckAnswerButton;

        private System.Windows.Forms.Label QuestionLabel;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem refreshFlashCardsToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newFlashCardToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFlashCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Label SubjectLabel;

        private System.Windows.Forms.Button refreshButton;

        #endregion

        private System.Windows.Forms.ComboBox SubjectDropDown;
        private System.Windows.Forms.ListBox CardsList;
    }
}

