namespace lab2_GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ���������� �������� �� ��������
            txt_a.Text = Properties.Settings.Default.a.ToString();
            txt_b.Text = Properties.Settings.Default.b.ToString();
            txt_c.Text = Properties.Settings.Default.c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c; // ������������� ���������� ��� �����
            try // ����� ������ ������ ����� ��� ����� ��������� ���� ������
            {
                a = int.Parse(this.txt_a.Text); // ������ �����
                b = int.Parse(this.txt_b.Text); // ������ �����
                c = int.Parse(this.txt_c.Text); // ������ �����

            }
            catch(FormatException)
            {
                MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // �������� ��������� �������� � ���������
            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            Properties.Settings.Default.Save();

            MessageBox.Show("������������ ���� ���������� �� ����: " + Logic.Compare(a, b, c)); ; // ����� ���������
        }
    }
    public class Logic
    {
        public static int Compare(int _a, int _b, int _c)
        {
            int max; // ���������� ��������������� ����������
            int outNum; // ���������� ���������� ��� ������ ���������

            if (_a > _b)
            { // ���������� ���� ���������� �� ���� �����
                max = _a;
            }
            else
            {
                max = _b;
            };
            if (_c > max)
            {
                max = _c;
            }
            outNum = (_a * _b * _c / max); // ������������ ���� ���������� �� ���� �����

            return outNum; // ����������� �������� �������
        }
    }
}