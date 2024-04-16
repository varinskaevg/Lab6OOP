namespace Lab6OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "А = ";
            label2.Text = "B = ";
            label3.Text = "Корінь рівняння:";
            btnOK.Text = "Порахувати";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);

                double x = -b / a;

                if (a == 0)
                {
                    MessageBox.Show("Коефіцієнт 'a' не може дорівнювати нулю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblResult.Text = x.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Введені дані повинні бути числовими.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }
    }
}
