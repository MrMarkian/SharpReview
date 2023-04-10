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
using Newtonsoft.Json;

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
            QuestionLabel.Text = "Please create a new card, or load existing cards.";
            foreach (var card in _flashcards)
            {
                if (!SubjectDropDown.Items.Contains(card.Subject))
                {
                    SubjectDropDown.Items.Add(card.Subject);
                }
            }
            tabControl1.TabPages.Clear();
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

            if (CardsList.Items.Count > 0)
            {
                CardsList.SelectedIndex = 0;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            int selectedSubject = SubjectDropDown.SelectedIndex;
            int selectedCardIndex = CardsList.SelectedIndex;
            
            SubjectDropDown.Items.Clear();
            
            foreach (var card in _flashcards)
            {
                if (!SubjectDropDown.Items.Contains(card.Subject))
                {
                    SubjectDropDown.Items.Add(card.Subject);
                }
            }

            SubjectDropDown.SelectedIndex = selectedSubject;
            CardsList.SelectedIndex = selectedCardIndex;

        }

        private void newFlashCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlashCardForm newCard = new AddFlashCardForm();
            if (SubjectDropDown.SelectedIndex >= 0)
            {
                newCard.currentSubject = SubjectDropDown.SelectedItem.ToString();
            }

            newCard.ShowDialog();
            refreshButton_Click(null, null);
        }

        private void CardsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CardsList.SelectedIndex < 0)
            {
                QuestionLabel.Text = "";
                return;
            }
            
            FlashCard _selectedCard = (FlashCard)CardsList.SelectedItem;

            tabControl1.TabPages.Clear();
            
            
            switch (_selectedCard.AnswerType)
            {
                case AnswerType.InformationOnly:
                    tabControl1.TabPages.Add(Info);
                    infoAnswerBox.Text = _selectedCard.CorrectSingleAnswer;
                    break;
                case AnswerType.SingleAnswer:
                    tabControl1.TabPages.Add(Single);
                    break;
                case AnswerType.MultipleChoice:
                    tabControl1.TabPages.Add(Multi);
                    break;
                default:
                    throw new Exception("Incorrect AnswerType");
                
            }

            
            
            QuestionLabel.Text = _selectedCard.QuestionText;
        }

        private void CheckAnswerButton_Click(object sender, EventArgs e)
        {
            if(CardsList.SelectedIndex < 0)
                return;
            
            FlashCard _selectedCard = (FlashCard)CardsList.SelectedItem;
            var answer =  _selectedCard.CheckSingleAnswer(AnswerInputBox.Text);
            MessageBox.Show("Your Answer is: " + answer);
        }

        private void LoadFlashCards()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            if (fileDialog.FileName != "")
            {
                _flashcards.Clear();
                string json = System.IO.File.ReadAllText(fileDialog.FileName);
                _flashcards = JsonConvert.DeserializeObject<List<FlashCard>>(json);
            }
            else
            {
                return;
            }
            refreshButton_Click(null, null);
            if (SubjectDropDown.SelectedIndex < 0)
            {
                SubjectDropDown.SelectedIndex = 0;
            }
        }

        private void saveFlashCardsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string FlashCardsInJson =JsonConvert.SerializeObject(_flashcards);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Flashcards to Json";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName,  FlashCardsInJson);
            }
            
        }

   
        private void loadFlashCardsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadFlashCards();
        }

        private void editFlashCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlashCardForm editngForm = new AddFlashCardForm();
            editngForm.cardInEdit =  (FlashCard)CardsList.SelectedItem;
            editngForm.isNewCard = false;
            editngForm.ShowDialog();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = true;
       
        }

 
        private void deleteFlashCardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            var confirmResult =  MessageBox.Show("Are you sure to delete this item ??",
                "Confirm Delete!!",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _flashcards.Remove((FlashCard)CardsList.SelectedItem);
            }
            else
            {
                return;
            }
           
        }

        private void appendFlashCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            if (fileDialog.FileName != "")
            {
               
                string json = System.IO.File.ReadAllText(fileDialog.FileName);
                _flashcards.AddRange(JsonConvert.DeserializeObject<List<FlashCard>>(json));
            }
            else
            {
                return;
            }
            refreshButton_Click(null, null);
            if (SubjectDropDown.SelectedIndex < 0)
            {
                SubjectDropDown.SelectedIndex = 0;
            }
        }

        private void removeAllLoadedCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult =  MessageBox.Show("Are you sure to remove all FlashCards?",
                "Confirm Delete!!",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
               _flashcards.Clear();
               CardsList.Items.Clear();
               SubjectDropDown.Items.Clear();
            }
            else
            {
               
            }
        }

      
    }
}
