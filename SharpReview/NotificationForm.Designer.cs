using System.ComponentModel;

namespace SharpReview
{
    partial class NotificationForm
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
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.BackColor = System.Drawing.Color.Silver;
            this.SubjectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubjectLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubjectLabel.Font = new System.Drawing.Font("Anka/Coder", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SubjectLabel.Location = new System.Drawing.Point(0, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(481, 28);
            this.SubjectLabel.TabIndex = 0;
            this.SubjectLabel.Text = "label1";
            this.SubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.BackColor = System.Drawing.Color.Silver;
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionLabel.Font = new System.Drawing.Font("Anka/Coder", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.QuestionLabel.Location = new System.Drawing.Point(0, 52);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(481, 124);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "label1";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BackColor = System.Drawing.Color.Silver;
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AnswerLabel.Font = new System.Drawing.Font("Anka/Coder", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AnswerLabel.Location = new System.Drawing.Point(0, 198);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(481, 100);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "label1";
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.ClientSize = new System.Drawing.Size(481, 298);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.SubjectLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NotificationForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label AnswerLabel;

        #endregion
    }
}