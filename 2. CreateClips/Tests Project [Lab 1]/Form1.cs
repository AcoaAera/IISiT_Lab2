using System;
using System.Windows.Forms;

namespace Tests_Project__Lab_1_
{
    public partial class Form1 : Form
    {
        WorkMemory workMemory;
        string currentFactName;
        int clicksCount, askedQuestionCount;

        public Form1()
        {
            InitializeComponent();
            clicksCount = 0;
            askedQuestionCount = 0;
            currentFactName = null;
            workMemory = new WorkMemory();
            SystemOutputTB.TabStop = false; // убирает фокус с текстбокса 
            SystemOutputTB.Text = "Вас приветствует экспертная система по выбору ВУЗа. Отвечайте на вопросы согласно правилам системы, пока не получите рекомендацию системы.\r\n\r\n";
            UserAnswerBTN.Text = "Начать";
        }

        void AnswerTheQuestion() // отправка ответа пользователя
        {
            string value = UserAnswerTB.Text;

            if (value == "Да" || value == "Нет")
                value = value.ToLower();

            SystemOutputTB.Text += " " + value;
            workMemory.ResponseProcessing(currentFactName, value);
            YesRB.Checked = NoRB.Checked = false;
            UserAnswerTB.Clear();
            SystemOutputTB.Text += "\r\n\r\n";
        }

        void GetQuestion() // получение нового вопроса
        {
            Tuple<string, string> questionAndCurrentFactName = workMemory.GetQuestionAndCurrentDefruleName();
            SystemOutputTB.Text += questionAndCurrentFactName.Item1;
            currentFactName = questionAndCurrentFactName.Item2;
        }

        private void UserAnswerBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (++clicksCount == 1)
                {
                    UserAnswerBTN.Text = "Ответить";
                    UserAnswerTB.Enabled = true;
                }
                else
                {
                    if (UserAnswerTB.Text == string.Empty)
                        throw new Exception("Поле ввода не должно быть пустым.");

                    AnswerTheQuestion();
                    ++askedQuestionCount; // количество заданных вопросов для обработки случаев, когда система не может вывести ответ

                    #region Проверка условия прекращения работы системы

                    Tuple<string, bool> corteg = workMemory.DefrulesEnumeration();
                    bool isFinal = corteg.Item2; // булевая переменная, возвращающая содержание факта типа "университет" в РП

                    if (askedQuestionCount == workMemory.QuestionsCount)
                    {
                        SystemOutputTB.Text += "Система не смогла выбрать ВУЗ, попробуйте еще раз.";
                        UserAnswerBTN.Enabled = false;
                        return;
                    }

                    if (isFinal)
                    {
                        SystemOutputTB.Text += "Система советует поступать в " + corteg.Item1;
                        UserAnswerBTN.Enabled = false;
                        return;
                    }

                    #endregion
                }

                GetQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void YesRB_CheckedChanged(object sender, EventArgs e)
        {
            UserAnswerTB.Text = "да";
        }

        private void NoRB_CheckedChanged(object sender, EventArgs e)
        {
            UserAnswerTB.Text = "нет";
        }

        private void SystemResetBTN_Click(object sender, EventArgs e)
        {
            clicksCount = 0;
            askedQuestionCount = 0;
            currentFactName = string.Empty;
            workMemory.Clear();
            SystemOutputTB.Text = "Вас приветствует экспертная система по выбору ВУЗа. Отвечайте на вопросы согласно правилам системы, пока не получите рекомендацию системы.\r\n\r\n";
            UserAnswerBTN.Text = "Начать";
            UserAnswerTB.Enabled = false;
            UserAnswerBTN.Enabled = true;
        }
    }
}
