using System.ComponentModel;

namespace SharpReview
{
    partial class AddFlashCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.FlashCardTypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newSubjectRadio = new System.Windows.Forms.RadioButton();
            this.ExistingSubjectCombo = new System.Windows.Forms.ComboBox();
            this.NewSubjectInput = new System.Windows.Forms.TextBox();
            this.ChooseExistingRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionInput = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SingleAnswerInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlashCardTypeCombo
            // 
            this.FlashCardTypeCombo.FormattingEnabled = true;
            this.FlashCardTypeCombo.Location = new System.Drawing.Point(163, 19);
            this.FlashCardTypeCombo.Name = "FlashCardTypeCombo";
            this.FlashCardTypeCombo.Size = new System.Drawing.Size(276, 21);
            this.FlashCardTypeCombo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newSubjectRadio);
            this.groupBox1.Controls.Add(this.ExistingSubjectCombo);
            this.groupBox1.Controls.Add(this.NewSubjectInput);
            this.groupBox1.Controls.Add(this.ChooseExistingRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Subject";
            // 
            // newSubjectRadio
            // 
            this.newSubjectRadio.Location = new System.Drawing.Point(20, 21);
            this.newSubjectRadio.Name = "newSubjectRadio";
            this.newSubjectRadio.Size = new System.Drawing.Size(95, 15);
            this.newSubjectRadio.TabIndex = 5;
            this.newSubjectRadio.TabStop = true;
            this.newSubjectRadio.Text = "New Subject";
            this.newSubjectRadio.UseVisualStyleBackColor = true;
            // 
            // ExistingSubjectCombo
            // 
            this.ExistingSubjectCombo.FormattingEnabled = true;
            this.ExistingSubjectCombo.Location = new System.Drawing.Point(145, 49);
            this.ExistingSubjectCombo.Name = "ExistingSubjectCombo";
            this.ExistingSubjectCombo.Size = new System.Drawing.Size(291, 21);
            this.ExistingSubjectCombo.TabIndex = 4;
            // 
            // NewSubjectInput
            // 
            this.NewSubjectInput.Location = new System.Drawing.Point(145, 17);
            this.NewSubjectInput.Name = "NewSubjectInput";
            this.NewSubjectInput.Size = new System.Drawing.Size(292, 20);
            this.NewSubjectInput.TabIndex = 3;
            // 
            // ChooseExistingRadio
            // 
            this.ChooseExistingRadio.Location = new System.Drawing.Point(18, 51);
            this.ChooseExistingRadio.Name = "ChooseExistingRadio";
            this.ChooseExistingRadio.Size = new System.Drawing.Size(136, 21);
            this.ChooseExistingRadio.TabIndex = 1;
            this.ChooseExistingRadio.TabStop = true;
            this.ChooseExistingRadio.Text = "Choose Existing";
            this.ChooseExistingRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.QuestionInput);
            this.groupBox2.Controls.Add(this.FlashCardTypeCombo);
            this.groupBox2.Location = new System.Drawing.Point(11, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text:";
            // 
            // QuestionInput
            // 
            this.QuestionInput.Location = new System.Drawing.Point(75, 52);
            this.QuestionInput.Name = "QuestionInput";
            this.QuestionInput.Size = new System.Drawing.Size(363, 54);
            this.QuestionInput.TabIndex = 2;
            this.QuestionInput.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(376, 378);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 30);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(11, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Answer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 97);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SingleAnswerInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SingleAnswerInput
            // 
            this.SingleAnswerInput.Location = new System.Drawing.Point(65, 6);
            this.SingleAnswerInput.Name = "SingleAnswerInput";
            this.SingleAnswerInput.Size = new System.Drawing.Size(380, 59);
            this.SingleAnswerInput.TabIndex = 3;
            this.SingleAnswerInput.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddFlashCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddFlashCardForm";
            this.Text = "New Flash Card";
            this.Load += new System.EventHandler(this.AddFlashCardForm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton newSubjectRadio;

        private System.Windows.Forms.TextBox NewSubjectInput;

        private System.Windows.Forms.RichTextBox SingleAnswerInput;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Button SaveButton;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ChooseExistingRadio;
        private System.Windows.Forms.TextBox newSubjectInput;
        private System.Windows.Forms.ComboBox ExistingSubjectCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox QuestionInput;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox FlashCardTypeCombo;

        #endregion
    }
}