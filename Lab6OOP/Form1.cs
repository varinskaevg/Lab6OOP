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
            label1.Text = "� = ";
            label2.Text = "B = ";
            label3.Text = "����� �������:";
            btnOK.Text = "����������";
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
                    MessageBox.Show("���������� 'a' �� ���� ���������� ����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblResult.Text = x.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("������ ��� ������ ���� ���������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }
    }
}
