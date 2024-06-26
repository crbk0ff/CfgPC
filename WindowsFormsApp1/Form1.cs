using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        private Form selectionForm;
        private ListBox listBox;
        private System.Windows.Forms.Button addButton;
        public main()
        {
            InitializeComponent();
            this.Controls.Add(textBox1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор модели материнской платы"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "ASUS ROG Maximus", "MSI MPG Z490", "AMD Gigabyte Z390 Aorus" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox1.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор модели процессора"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "Intel Core i9", "AMD Ryzen 9", "Intel Core i7" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click1;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click1(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox2.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор корпуса"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "Corsair", "Cooler Master", "NZXT" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click2;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click2(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox3.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор модели видеокарты"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "NVIDIA RTX 3080", "AMD Radeon RX 6800 XT", "NVIDIA GTX 1660 Ti" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click3;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click3(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox4.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор оперативной памяти"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "Corsair Vengeance", "G.Skill Trident Z", "Kingston HyperX" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click4;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click4(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox5.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор жесткого диска"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "Seagate Barracuda", "WD Blue", "Samsung 860 Evo", "Crucial MX500" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click5;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click5(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox9.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор блока питания"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "Corsair RMx Series", "EVGA SuperNOVA", "Seasonic FOCUS Plus", "Cooler Master V Series" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click6;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click6(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox7.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectionForm = new Form
            {
                Width = 300,
                Height = 200,
                Text = "Выбор куллеров"
            };

            listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(new string[] { "Cooler Master Hyper 212", "Noctua NH-D15", "Be Quiet! Dark Rock Pro 4", "NZXT Kraken X73" });
            selectionForm.Controls.Add(listBox);

            addButton = new System.Windows.Forms.Button { Text = "Добавить", Dock = DockStyle.Bottom };
            addButton.Click += AddButton_Click7;
            selectionForm.Controls.Add(addButton);

            selectionForm.ShowDialog();
        }
        private void AddButton_Click7(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                textBox8.Text = listBox.SelectedItem.ToString();
                selectionForm.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "AMD Gigabyte Z390 Aorus" && textBox2.Text == "Intel Core i9" || textBox1.Text == "AMD Gigabyte Z390 Aorus" && textBox2.Text == "Intel Core i7" || textBox1.Text == "ASUS ROG Maximus" && textBox2.Text == "AMD Ryzen 9" || textBox1.Text == "MSI MPG Z490" && textBox2.Text == "AMD Ryzen 9")
            {
                MessageBox.Show("Не совместимо");
            }
            else
            {
                MessageBox.Show("Совместимо");
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string матплат = textBox1.Text;
            double стоимость = 0;
            switch (матплат)
            {
                case "ASUS ROG Maximus":
                    стоимость += 71990;
                    break;
                case "MSI MPG Z490":
                    стоимость += 12000;
                    break;
                case "AMD Gigabyte Z390 Aorus":
                    стоимость += 16999;
                    break;
            }
            label2.Text = $"{стоимость}";
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string проц = textBox2.Text;
            double стоимость = 0;
            switch (проц)
            {
                case "Intel Core i9":
                    стоимость += 40990;
                    break;
                case "AMD Ryzen 9":
                    стоимость += 39000;
                    break;
                case "Intel Core i7":
                    стоимость += 22000;
                    break;
            }
            label3.Text = $"{стоимость}";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string корп = textBox3.Text;
            double стоимость = 0;
            switch (корп)
            {
                case "Corsair":
                    стоимость += 11000;
                    break;
                case "Cooler Master":
                    стоимость += 5000;
                    break;
                case "NZXT":
                    стоимость += 19000;
                    break;
            }
            label4.Text = $"{стоимость}";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string видео = textBox4.Text;
            double стоимость = 0;
            switch (видео)
            {
                case "NVIDIA RTX 3080":
                    стоимость += 90000;
                    break;
                case "AMD Radeon RX 6800 XT":
                    стоимость += 102000;
                    break;
                case "NVIDIA GTX 1660 Ti":
                    стоимость += 20000;
                    break;
            }
            label5.Text = $"{стоимость}";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string опер = textBox5.Text;
            double стоимость = 0;
            switch (опер)
            {
                case "Corsair Vengeance":
                    стоимость += 10000;
                    break;
                case "G.Skill Trident Z":
                    стоимость += 5800;
                    break;
                case "Kingston HyperX":
                    стоимость += 8000;
                    break;
            }
            label6.Text = $"{стоимость}";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string жесть = textBox9.Text;
            double стоимость = 0;
            switch (жесть)
            {
                case "Seagate Barracuda":
                    стоимость += 6900;
                    break;
                case "WD Blue":
                    стоимость += 4000;
                    break;
                case "Samsung 860 Evo":
                    стоимость += 10000;
                    break;
                case "Crucial MX500":
                    стоимость += 7500;
                    break;
            }
            label7.Text = $"{стоимость}";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string блок = textBox7.Text;
            double стоимость = 0;
            switch (блок)
            {
                case "Corsair RMx Series":
                    стоимость += 5990;
                    break;
                case "EVGA SuperNOVA":
                    стоимость += 29000;
                    break;
                case "Seasonic FOCUS Plus":
                    стоимость += 34000;
                    break;
                case "Cooler Master V Series":
                    стоимость += 12000;
                    break;
            }
            label8.Text = $"{стоимость}";
        }

        public void textBox8_TextChanged(object sender, EventArgs e)
        {
            string охл = textBox8.Text;
            double стоимость = 0;
            switch (охл)
            {
                case "Cooler Master Hyper 212":
                    стоимость += 4100;
                    break;
                case "Noctua NH-D15":
                    стоимость += 11900;
                    break;
                case "Be Quiet! Dark Rock Pro 4":
                    стоимость += 15000;
                    break;
                case "NZXT Kraken X73":
                    стоимость += 24300;
                    break;
            }
            label9.Text = $"{стоимость}";
            
        }
        public void rasch()
        {
            int q = int.Parse(label2.Text);
            int sto = Convert.ToInt32(q);
            int w = int.Parse(label3.Text);
            int sto1 = Convert.ToInt32(w);
            int e = int.Parse(label4.Text);
            int sto2 = Convert.ToInt32(e);
            int r = int.Parse(label5.Text);
            int sto3 = Convert.ToInt32(r);
            int t = int.Parse(label6.Text);
            int sto4 = Convert.ToInt32(t);
            int y = int.Parse(label7.Text);
            int sto5 = Convert.ToInt32(y);
            int u = int.Parse(label8.Text);
            int sto6 = Convert.ToInt32(u);
            int i = int.Parse(label9.Text);
            int sto7 = Convert.ToInt32(i);
            int full = sto + sto1 + sto2 + sto3 + sto4 + sto5 + sto6 + sto7;
            textBox6.Text = $"{Convert.ToString(full)} рублей";
        }
        public void prove()
        {

            if (string.IsNullOrWhiteSpace(label2.Text) ||
                (string.IsNullOrWhiteSpace(label3.Text) ||
                (string.IsNullOrWhiteSpace(label4.Text) ||
                (string.IsNullOrWhiteSpace(label5.Text) ||
                (string.IsNullOrWhiteSpace(label6.Text) ||
                (string.IsNullOrWhiteSpace(label7.Text) ||
                (string.IsNullOrWhiteSpace(label8.Text) ||
                (string.IsNullOrWhiteSpace(label9.Text)))))))))
            {
                MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rasch();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            prove();
        }
        public void otch()
        {
            otch otch = new otch();
            otch.Show();
            otch.InputText1 = $"Материнская плата: {textBox1.Text} - {label2.Text} рублей \r\n\r\nПроцессор: {textBox2.Text} - {label3.Text} рублей \r\n\r\nКорпус: {textBox3.Text} - {label4.Text} рублей \r\n\r\nВидеокарта: {textBox4.Text} - {label5.Text} рублей \r\n\r\nОперативная память: {textBox5.Text} - {label6.Text} рублей \r\n\r\nЖесткий диск: {textBox9.Text} - {label7.Text} рублей рублей \r\n\r\nБлок питания: {textBox7.Text} - {label8.Text} рублей \r\n\r\nКуллер: {textBox8.Text} - {label9.Text} рублей \r\n\r\nОбщая стоимость: {textBox6.Text} рублей";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            otch();
        }
    }
}
