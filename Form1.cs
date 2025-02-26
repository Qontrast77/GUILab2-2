using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик клика по кнопке "Проверить"
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string word1 = txtWord1.Text;  // Получаем первое слово
            string word2 = txtWord2.Text;  // Получаем второе слово

            Logic logic = new Logic();  // Создаем объект класса Logic
            string result = logic.CheckLetters(word1, word2);  // Получаем результат проверки

            lblResult.Text = result;  // Выводим результат в метку lblResult
        }
    }

    // Класс для логики проверки букв
    public class Logic
    {
        // Метод проверки букв из первого слова во втором
        public string CheckLetters(string word1, string word2)
        {
            HashSet<char> checkedChars = new HashSet<char>();  // Множество для проверки уникальности символов
            List<string> result = new List<string>();  // Список для хранения результатов

            foreach (char c in word1)
            {
                // Пропускаем символ, если он уже проверен
                if (checkedChars.Contains(c))
                {
                    continue;
                }

                checkedChars.Add(c);  // Добавляем символ в множество для проверки

                // Если символ есть во втором слове, добавляем "да", иначе "нет"
                if (word2.Contains(c))
                {
                    result.Add("да");
                }
                else
                {
                    result.Add("нет");
                }
            }

            return string.Join(" ", result);  // Возвращаем строку с результатами
        }
    }
}
