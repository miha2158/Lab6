using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayBox1.Text = "Введите \r\nили сгенерируйте \r\nваш массив";
            WordsBox.Text = "Введите вашу строку";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            /*if (MainArray == null)
                RandomButton_Click(sender, e);
            else*/
            {
                MainArray = Tasks.StringToArray(ArrayBox1.Text.Replace("  "," ").Split('\n'));
                ArrayBox1.Text = Tasks.ArrayToString(MainArray);
            }
            if (!Pass)
            {
                Pass = true;
                SortedArrayBox.Text = Tasks.ArrayToString(Tasks.SortIt(MainArray));
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            MainArray = null;
            Pass = false;
            Tasks.Randomise(ref MainArray);
            SortedArrayBox.Text = null;
            ArrayBox1.Text = Tasks.ArrayToString(MainArray);
        }

        private void ArrayBox1_TextChanged(object sender, EventArgs e)
        {
            Pass = false;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            string temp = WordsBox.Text.Trim();

            try
            {
                temp = temp.Remove(0, temp.IndexOf(" "));
                temp = temp.Remove(temp.LastIndexOf(" "));
            }
            catch (Exception)
            {
                if (temp.LastIndexOf(" ") == -1)
                    temp = "";
            }
            WordsBox2.Text = temp;
        }

        private void WordsBox_TextChanged(object sender, EventArgs e)
        {
            WordsBox.Text.Replace("  ", " ");
        }

        char[][] MainArray;
        private bool Pass = false;
    }
}
