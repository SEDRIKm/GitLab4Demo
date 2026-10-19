namespace GitLab4Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа работает!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа № 4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Новая функция из ветки AddFunction!");
        }
    }
}
