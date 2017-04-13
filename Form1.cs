using System;
using System.Windows.Forms;

namespace FIFO_Buffer
{
    public partial class Form1 : Form
    {
        Queue<string> queueStr = new Queue<string>();
        Queue<int> queueInt = new Queue<int>();
        int intTmp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsInt = int.TryParse(textBox1.Text, out intTmp);
                if (textBox1.Text == string.Empty)
                    MessageBox.Show("Cтрока пуста", "Ошибка");
                else if (IsInt == false)
                    MessageBox.Show("Введенное значение не является целочисленным числом или выходит за пределы int", "Ошибка");
                else
                {
                    queueInt.Enqueue(intTmp);
                }

            }
            catch(EmptyList ex)
            {
                MessageBox.Show("Очередь пуста (" + ex.Message + ")", "Ошибка");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: "+ ex.Message, "Ошибка");
            }
            finally
            {
                textBox1.Clear();
                richTextBox1.Text = queueInt.PrintResult();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty)
                    MessageBox.Show("Cтрока пуста", "Ошибка");
                else
                {
                    queueStr.Enqueue(textBox1.Text);
                }

            }
            catch (EmptyList ex)
            {
                MessageBox.Show("Очередь пуста (" + ex.Message + ")", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
            finally
            {
                textBox1.Clear();
                richTextBox2.Text = queueStr.PrintResult();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (queueInt.Count() == 0)
                    MessageBox.Show("Буфер пуст", "Ошибка");
                else
                {
                    textBox3.Text = queueInt.Dequeue();
                }

            }
            catch (EmptyList ex)
            {
                MessageBox.Show("Очередь пуста (" + ex.Message + ")", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
            finally
            {
                richTextBox1.Text = queueInt.PrintResult();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (queueStr.Count() == 0)
                    MessageBox.Show("Буфер пуст", "Ошибка");
                else
                {
                    textBox3.Text = queueStr.Dequeue();
                }

            }
            catch (EmptyList ex)
            {
                MessageBox.Show("Очередь пуста (" + ex.Message + ")", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
            finally
            {
                richTextBox2.Text = queueStr.PrintResult();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (queueInt.Count() == 0)
                    MessageBox.Show("Буфер пуст", "Ошибка");
                else
                {
                    if(queueInt.Contains(int.Parse(textBox2.Text)))
                        MessageBox.Show("Да, содержит", "Ответ");
                    else
                        MessageBox.Show("Нет, не содержит", "Ответ");
                }

            }
            catch (EmptyList ex)
            {
                MessageBox.Show("Очередь пуста (" + ex.Message + ")", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
            finally
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (queueStr.Count() == 0)
                    MessageBox.Show("Буфер пуст", "Ошибка");
                else
                {
                    if (textBox2.Text == string.Empty)
                        MessageBox.Show("Введена пустая строка", "Ошибка");
                    else
                    {
                        if (queueStr.Contains(textBox2.Text))
                            MessageBox.Show("Да, содержит", "Ответ");
                        else
                            MessageBox.Show("Нет, не содержит", "Ответ");
                    }
                }

            }
            catch (EmptyList ex)
            {
                MessageBox.Show("Очередь пуста (" + ex.Message + ")", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
            finally
            {

            }
        }
    }
}
