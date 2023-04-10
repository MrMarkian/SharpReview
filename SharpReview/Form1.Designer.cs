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
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFlashCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFlashCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFlashCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllLoadedCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerInputBox = new System.Windows.Forms.TextBox();
            this.CheckAnswerButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Single = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Multi = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.TabPage();
            this.infoAnswerBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Single.SuspendLayout();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectDropDown
            // 
            this.SubjectDropDown.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectDropDown.FormattingEnabled = true;
            this.SubjectDropDown.Location = new System.Drawing.Point(11, 34);
            this.SubjectDropDown.Name = "SubjectDropDown";
            this.SubjectDropDown.Size = new System.Drawing.Size(228, 21);
            this.SubjectDropDown.TabIndex = 0;
            this.SubjectDropDown.SelectedIndexChanged += new System.EventHandler(this.SubjectDropDown_SelectedIndexChanged);
            // 
            // CardsList
            // 
            this.CardsList.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CardsList.FormattingEnabled = true;
            this.CardsList.Location = new System.Drawing.Point(12, 73);
            this.CardsList.Name = "CardsList";
            this.CardsList.Size = new System.Drawing.Size(227, 446);
            this.CardsList.TabIndex = 1;
            this.CardsList.SelectedIndexChanged += new System.EventHandler(this.CardsList_SelectedIndexChanged);
            this.CardsList.DoubleClick += new System.EventHandler(this.editFlashCardToolStripMenuItem_Click);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Location = new System.Drawing.Point(12, 11);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(80, 19);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "Subject";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.newFlashCardToolStripMenuItem, this.toolStripSeparator3, this.loadFlashCardsToolStripMenuItem, this.appendFlashCardsToolStripMenuItem, this.saveFlashCardsToolStripMenuItem, this.toolStripSeparator1, this.refreshFlashCardsToolStripMenuItem, this.toolStripSeparator2, this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFlashCardToolStripMenuItem
            // 
            this.newFlashCardToolStripMenuItem.Name = "newFlashCardToolStripMenuItem";
            this.newFlashCardToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newFlashCardToolStripMenuItem.Text = "New FlashCard";
            this.newFlashCardToolStripMenuItem.Click += new System.EventHandler(this.newFlashCardToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // loadFlashCardsToolStripMenuItem
            // 
            this.loadFlashCardsToolStripMenuItem.Name = "loadFlashCardsToolStripMenuItem";
            this.loadFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.loadFlashCardsToolStripMenuItem.Text = "Load FlashCards";
            this.loadFlashCardsToolStripMenuItem.Click += new System.EventHandler(this.loadFlashCardsToolStripMenuItem_Click_1);
            // 
            // appendFlashCardsToolStripMenuItem
            // 
            this.appendFlashCardsToolStripMenuItem.Name = "appendFlashCardsToolStripMenuItem";
            this.appendFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.appendFlashCardsToolStripMenuItem.Text = "Append FlashCards";
            this.appendFlashCardsToolStripMenuItem.Click += new System.EventHandler(this.appendFlashCardsToolStripMenuItem_Click);
            // 
            // saveFlashCardsToolStripMenuItem
            // 
            this.saveFlashCardsToolStripMenuItem.Name = "saveFlashCardsToolStripMenuItem";
            this.saveFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveFlashCardsToolStripMenuItem.Text = "Save FlashCards";
            this.saveFlashCardsToolStripMenuItem.Click += new System.EventHandler(this.saveFlashCardsToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // refreshFlashCardsToolStripMenuItem
            // 
            this.refreshFlashCardsToolStripMenuItem.Name = "refreshFlashCardsToolStripMenuItem";
            this.refreshFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.refreshFlashCardsToolStripMenuItem.Text = "Refresh FlashCards";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.editFlashCardToolStripMenuItem, this.toolStripSeparator4, this.deleteFlashCardToolStripMenuItem, this.removeAllLoadedCardsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editFlashCardToolStripMenuItem
            // 
            this.editFlashCardToolStripMenuItem.Name = "editFlashCardToolStripMenuItem";
            this.editFlashCardToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.editFlashCardToolStripMenuItem.Text = "Edit FlashCard";
            this.editFlashCardToolStripMenuItem.Click += new System.EventHandler(this.editFlashCardToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // deleteFlashCardToolStripMenuItem
            // 
            this.deleteFlashCardToolStripMenuItem.Name = "deleteFlashCardToolStripMenuItem";
            this.deleteFlashCardToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deleteFlashCardToolStripMenuItem.Text = "Delete FlashCard";
            this.deleteFlashCardToolStripMenuItem.Click += new System.EventHandler(this.deleteFlashCardToolStripMenuItem_Click_1);
            // 
            // removeAllLoadedCardsToolStripMenuItem
            // 
            this.removeAllLoadedCardsToolStripMenuItem.Name = "removeAllLoadedCardsToolStripMenuItem";
            this.removeAllLoadedCardsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.removeAllLoadedCardsToolStripMenuItem.Text = "Remove All Loaded Cards";
            this.removeAllLoadedCardsToolStripMenuItem.Click += new System.EventHandler(this.removeAllLoadedCardsToolStripMenuItem_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.Font = new System.Drawing.Font("Anka/Coder", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.QuestionLabel.Location = new System.Drawing.Point(24, 73);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(443, 267);
            this.QuestionLabel.TabIndex = 6;
            this.QuestionLabel.Text = "Question";
            // 
            // AnswerInputBox
            // 
            this.AnswerInputBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerInputBox.Location = new System.Drawing.Point(20, 37);
            this.AnswerInputBox.Name = "AnswerInputBox";
            this.AnswerInputBox.Size = new System.Drawing.Size(467, 20);
            this.AnswerInputBox.TabIndex = 7;
            // 
            // CheckAnswerButton
            // 
            this.CheckAnswerButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckAnswerButton.Location = new System.Drawing.Point(390, 136);
            this.CheckAnswerButton.Name = "CheckAnswerButton";
            this.CheckAnswerButton.Size = new System.Drawing.Size(107, 27);
            this.CheckAnswerButton.TabIndex = 8;
            this.CheckAnswerButton.Text = "Check Answer";
            this.CheckAnswerButton.UseVisualStyleBackColor = true;
            this.CheckAnswerButton.Click += new System.EventHandler(this.CheckAnswerButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Single);
            this.tabControl1.Controls.Add(this.Multi);
            this.tabControl1.Controls.Add(this.Info);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 343);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 197);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // Single
            // 
            this.Single.Controls.Add(this.label1);
            this.Single.Controls.Add(this.AnswerInputBox);
            this.Single.Controls.Add(this.CheckAnswerButton);
            this.Single.Location = new System.Drawing.Point(4, 22);
            this.Single.Name = "Single";
            this.Single.Padding = new System.Windows.Forms.Padding(3);
            this.Single.Size = new System.Drawing.Size(505, 171);
            this.Single.TabIndex = 0;
            this.Single.Text = "Single Answer";
            this.Single.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type Answer:";
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(4, 22);
            this.Multi.Name = "Multi";
            this.Multi.Padding = new System.Windows.Forms.Padding(3);
            this.Multi.Size = new System.Drawing.Size(505, 171);
            this.Multi.TabIndex = 1;
            this.Multi.Text = "Multi Answers";
            this.Multi.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.infoAnswerBox);
            this.Info.Location = new System.Drawing.Point(4, 22);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(505, 171);
            this.Info.TabIndex = 2;
            this.Info.Text = "Information";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // infoAnswerBox
            // 
            this.infoAnswerBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.infoAnswerBox.BackColor = System.Drawing.SystemColors.Menu;
            this.infoAnswerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoAnswerBox.Font = new System.Drawing.Font("Anka/Coder", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.infoAnswerBox.Location = new System.Drawing.Point(20, 15);
            this.infoAnswerBox.Name = "infoAnswerBox";
            this.infoAnswerBox.Size = new System.Drawing.Size(467, 137);
            this.infoAnswerBox.TabIndex = 0;
            this.infoAnswerBox.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CardsList);
            this.splitContainer1.Panel1.Controls.Add(this.SubjectLabel);
            this.splitContainer1.Panel1.Controls.Add(this.SubjectDropDown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.QuestionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(786, 544);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 568);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SharpReview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Single.ResumeLayout(false);
            this.Single.PerformLayout();
            this.Info.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.ToolStripMenuItem removeAllLoadedCardsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem appendFlashCardsToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem deleteFlashCardToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem editFlashCardToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.RichTextBox infoAnswerBox;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Single;
        private System.Windows.Forms.TabPage Multi;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadFlashCardsToolStripMenuItem;

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

        #endregion

        private System.Windows.Forms.ComboBox SubjectDropDown;
        private System.Windows.Forms.ListBox CardsList;
    }
}

