using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    internal class AddClientForm : Form
    {
        private GroupBox groupBox1;
        public TextBox textBox4;
        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox8;
        public TextBox textBox7;
        public TextBox textBox6;
        public TextBox textBox5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        public TextBox textBox9;
        private Label label10;
        public Label label11;
        private Button button1;
        public TextBox textBox1;
        PizzaDeliveryContext dbContext/* = new PizzaDeliveryContext()*/;
        private clients ncl;

        public AddClientForm(PizzaDeliveryContext dbContext, clients ncl)
        {
            InitializeComponent();
            this.ncl = ncl;
            this.dbContext = dbContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные клиента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Адрес";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Повторите пароль*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Почта";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Телефон*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пароль*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Логин*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя*";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(147, 213);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(137, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(147, 184);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(147, 157);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(137, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(137, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(161, 256);
            this.textBox9.Name = "textBox9";
            this.textBox9.PasswordChar = '*';
            this.textBox9.Size = new System.Drawing.Size(137, 20);
            this.textBox9.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "* - обязательное поле";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Пароли должны совпадать";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddClientForm
            // 
            this.ClientSize = new System.Drawing.Size(386, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddClientForm";
            this.Text = "Новый клиент";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox9.Text != textBox5.Text)
            {
                label11.Text = "Пароли не совпадают";
            }
            else
            {
                if (ncl==null)
                {
                    bool flag = true;
                    foreach(var symbol in textBox6.Text)
                        if (!char.IsDigit(symbol))
                        {
                            flag = false;
                            break;
                        }
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" &&
                        textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" &&textBox7.Text.Contains('@')&&flag)
                    {
                        clients ncl = new clients();
                        ncl.first_name = textBox1.Text;
                        ncl.last_name = textBox2.Text;
                        ncl.surname = textBox3.Text;
                        ncl.login = textBox4.Text;
                        ncl.C_password = textBox5.Text;
                        ncl.phone = textBox6.Text;
                        ncl.email = textBox7.Text;
                        ncl.address = textBox8.Text;


                        dbContext.clients.Add(ncl);
                        try
                        {
                            dbContext.SaveChanges();
                            Close();
                            MessageBox.Show("Новый объект добавлен");
                        }
                        catch (Npgsql.PostgresException se)
                        {
                            label11.Text = $"Processing failed: {se.Message}";
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException sa)
                        {
                            label11.Text = $"Processing failed: {sa.InnerException.InnerException.Message}";
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException so)
                        {
                            label11.Text = $"Processing failed: {so.Message}\n Проверьте наличие обязательных полей";
                        }
                    }
                    else
                    {
                        label11.Text = "Processing failed: Проверьте наличие обязательных полей";

                    }
                }
                else
                {
                    bool flag = true;
                    foreach (var symbol in textBox6.Text)
                        if (!char.IsDigit(symbol))
                        {
                            flag = false;
                            break;
                        }
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" &&
                        textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox7.Text.Contains('@') && flag)
                    {
                        ncl.first_name = textBox1.Text;
                        ncl.last_name = textBox2.Text;
                        ncl.surname = textBox3.Text;
                        ncl.login = textBox4.Text;
                        ncl.C_password = textBox5.Text;
                        ncl.phone = textBox6.Text;
                        ncl.email = textBox7.Text;
                        ncl.address = textBox8.Text;
                        try
                        {
                            dbContext.SaveChanges();
                            Close();
                            MessageBox.Show("Объект успешно изменен");
                        }
                        catch (Npgsql.PostgresException se)
                        {
                            label11.Text = $"Processing failed: {se.Message}";
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException sa)
                        {
                            label11.Text = $"Processing failed: {sa.InnerException.Message}, {sa.HResult}";
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException so)
                        {
                            label11.Text = $"Processing failed: {so.Message}\n Проверьте наличие обязательных полей";

                        }
                    }
                    else
                    {
                        label11.Text = "Processing failed: Проверьте наличие обязательных полей";

                    }
                }


            }


        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
