using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SharpReview.Data;

namespace SharpReview
{
    public partial class AddFlashCardForm : Form
    {
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
            FlashCard tempCard = new FlashCard();
       
        }
    }
}