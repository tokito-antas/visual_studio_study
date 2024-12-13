namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            int valueLeft = InputCheck(input1TextBox.Text);
            int valueRight = InputCheck(input2TextBox.Text);
            int valueAnswer = valueLeft + valueRight;

            answerTextBox.Text = valueAnswer.ToString();
        }

        private int InputCheck(string textValue)
        {
            if (int.TryParse(textValue, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

    }
}
