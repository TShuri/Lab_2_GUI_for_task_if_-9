namespace lab2_GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Считывание значений из настроек
            txt_a.Text = Properties.Settings.Default.a.ToString();
            txt_b.Text = Properties.Settings.Default.b.ToString();
            txt_c.Text = Properties.Settings.Default.c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c; // Инициализация переменных для чисел
            try // Ловим ошибки пустих полей или ввода неверного типа данных
            {
                a = int.Parse(this.txt_a.Text); // Первое число
                b = int.Parse(this.txt_b.Text); // Второе число
                c = int.Parse(this.txt_c.Text); // Третье число

            }
            catch(FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Передаем введенные значения в параметры
            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            Properties.Settings.Default.Save();

            MessageBox.Show("Произведение двух наименьших из трех: " + Logic.Compare(a, b ,c)); // Вывод сообщения
        }
    }
    public class Logic
    {
        public static string Compare(int _a, int _b, int _c)
        {
            int max; // Объявление вспомогательной переменной
            string outMessage = ""; // Объявление переменной для вывода сообщения

            if (_a > _b)
            { // Нахождение двух наименьших из трех чисел
                max = _a;
            }
            else
            {
                max = _b;
            };
            if (_c > _b)
            {
                max = _c;
            }
            outMessage = (_a * _b * _c / max).ToString(); // Произведение двух наименьших из трех чисел

            return outMessage; // Возвращение значения функции
        }
    }
}