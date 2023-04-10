using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpReview.Data;

namespace SharpReview
{
    public partial class Form1 : Form
    {
        static List<FlashCard> _flashcards = new List<FlashCard>();

        public Form1()
        {
            InitializeComponent();
        }

        public static List<FlashCard> GetCards()
        {
            return _flashcards;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FlashCard testCard = new FlashCard();
            testCard.Subject = "SDLC - Project Planning";
            testCard.QuestionText = "Why did the chicken cross the road?";
            testCard.CorrectSingleAnswer = "To get to the other side";
            _flashcards.Add(testCard);
            
            FlashCard testCard2 = new FlashCard();
            testCard2.Subject = "SDLC - Design";
            testCard2.QuestionText = "Can a queef smell of fish?";
            testCard2.CorrectSingleAnswer = "yes";
            _flashcards.Add(testCard2);
            
            
            foreach (var card in _flashcards)
            {
                if (!SubjectDropDown.Items.Contains(card.Subject))
                {
                    SubjectDropDown.Items.Add(card.Subject);
                }
            }
        }

        private void SubjectDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CardsList.Items.Clear();
            foreach (var card in _flashcards)
            {
                if (card.Subject == SubjectDropDown.SelectedItem.ToString())
                {
                    CardsList.Items.Add(card);
                }
            }
        }

       
        private void NewFlashCardButton_Click(object sender, EventArgs e)
        {
          
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SubjectDropDown.Items.Clear();
            
            foreach (var card in _flashcards)
            {
                if (!SubjectDropDown.Items.Contains(card.Subject))
                {
                    SubjectDropDown.Items.Add(card.Subject);
                }
            }
            
            
        }

        private void newFlashCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlashCardForm newCard = new AddFlashCardForm();
            newCard.ShowDialog();
            refreshButton_Click(null, null);
        }

        private void CardsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlashCard _selectedCard = (FlashCard)CardsList.SelectedItem;
            QuestionLabel.Text = _selectedCard.QuestionText;
        }

        private void CheckAnswerButton_Click(object sender, EventArgs e)
        {
            FlashCard _selectedCard = (FlashCard)CardsList.SelectedItem;
            var answer =  _selectedCard.CheckSingleAnswer(AnswerInputBox.Text);
            MessageBox.Show("Your Answer is: " + answer);
        }
    }
}
