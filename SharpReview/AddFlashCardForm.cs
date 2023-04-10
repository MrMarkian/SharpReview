using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SharpReview.Data;

namespace SharpReview
{
    public partial class AddFlashCardForm : Form
    {
        public bool isNewCard = true;

        public FlashCard cardInEdit;
        public AddFlashCardForm()
        {
            InitializeComponent();
            FlashCardTypeCombo.DataSource = Enum.GetValues(typeof(AnswerType));
        }


        private void AddFlashCardForm_Load_1(object sender, EventArgs e)
        {
            foreach (var card in Form1.GetCards())
            {
                if(!ExistingSubjectCombo.Items.Contains(card.Subject))
                {
                    ExistingSubjectCombo.Items.Add(card.Subject);
                }
                
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isNewCard)
            {
                FlashCard tempCard = new FlashCard();
                tempCard.QuestionText = QuestionInput.Text;

                if (newSubjectRadio.Checked)
                {
                    tempCard.Subject = NewSubjectInput.Text;
                }
                else
                {
                    tempCard.Subject = ExistingSubjectCombo.Text;
                }

                tempCard.CorrectSingleAnswer = SingleAnswerInput.Text;

                Form1.GetCards().Add(tempCard);
            }
            else
            {
                cardInEdit.Subject = NewSubjectInput.Text;
                
                if (newSubjectRadio.Checked)
                {
                    cardInEdit .Subject = NewSubjectInput.Text;
                }
                else
                {
                    cardInEdit.Subject = ExistingSubjectCombo.Text;
                }

                cardInEdit.CorrectSingleAnswer = SingleAnswerInput.Text;
                
            }
            
            this.Close();

        }
    }
}