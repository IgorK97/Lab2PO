using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        PizzaDeliveryContext dbContext=new PizzaDeliveryContext();
        private string connectionString;
        List<clients> allClients;
        List<DelStatus> delStatuses;
        List<couriers> allCouriers;
        //private NpgsqlDataAdapter clientsAdapter;
        //private NpgsqlDataAdapter ordersAdapter;
        //private NpgsqlDataAdapter couriersAdapter;
        //private NpgsqlDataAdapter statusAdapter;


        //private NpgsqlCommandBuilder clientsBuilder = new NpgsqlCommandBuilder();
        //private NpgsqlCommandBuilder ordersBuilder = new NpgsqlCommandBuilder();

        //private DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            //connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            //clientsAdapter = new NpgsqlDataAdapter("SELECT * FROM public.clients\r\nORDER BY id ASC", connectionString);
            //ordersAdapter = new NpgsqlDataAdapter("SELECT * FROM public.orders\r\nORDER BY id ASC ", connectionString);
            //couriersAdapter = new NpgsqlDataAdapter("SELECT * FROM public.couriers\r\nORDER BY id ASC ", connectionString);
            //statusAdapter = new NpgsqlDataAdapter("SELECT * FROM public.\"DelStatus\"\r\nORDER BY id ASC ", connectionString);

            //// Автоматическая генерация команд SQL.
            //clientsBuilder = new NpgsqlCommandBuilder(clientsAdapter);
            //ordersBuilder = new NpgsqlCommandBuilder(ordersAdapter);

            //// Заполнение таблиц в DataSet.
            //clientsAdapter.Fill(dataSet, "clients");
            //ordersAdapter.Fill(dataSet, "orders");
            //couriersAdapter.Fill(dataSet, "couriers");
            //statusAdapter.Fill(dataSet, "status");


            //dataGridViewClients.DataSource = dataSet.Tables["clients"];
            //dataGridViewOrders.DataSource = dataSet.Tables["orders"];
            LoadClients();
            LoadCouriers();
            LoadStatuses();
            LoadOrders();
            dataGridViewOrders.Columns[7].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";




            FillCourierCombobox();
            FillClientCombobox();
            FillStatusCombobox();
            FillReport1Combobox();
        }
        private void LoadClients()
        {
            dbContext.clients.Load();
            allClients = dbContext.clients.Local.ToList();
            dataGridViewClients.DataSource = allClients;

        }
        private void LoadCouriers()
        {
            dbContext.couriers.Load();
            allCouriers = dbContext.couriers.Local.ToList();

        }
        private void LoadStatuses()
        {
            dbContext.DelStatus.Load();
            delStatuses = dbContext.DelStatus.Local.ToList();

        }

        private void LoadOrders()
        {
            dataGridViewOrders.DataSource = dbContext.orders.Include("Clients").ToList().Select(i => new { i.id, i.ordertime, i.final_price, i.clientId, i.courierId, i.delstatusId, i.address_del, i.deliverytime, i.comment, i.weight}).ToList();
        }

        private void FillStatusCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatusid"]).DataSource =
                delStatuses;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatusid"]).DisplayMember =
                "description";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatusid"]).ValueMember =
                "id";
        }

        private void FillClientCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["ClientId"]).DataSource =
                allClients;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["ClientId"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["ClientId"]).ValueMember =
                "id";
        }

        private void FillReport1Combobox()
        {
            //using (var sqlConnection = new NpgsqlConnection(connectionString))
            //{
            //    NpgsqlDataAdapter sqlAdapter = new NpgsqlDataAdapter("SELECT * FROM public.ingredients\r\nORDER BY id ASC ", sqlConnection);

            //    // Заполнение dataSet данными из sqlAdapter.
            //    DataSet dataSet = new DataSet();
            //    sqlAdapter.Fill(dataSet, "ingredients");

            //    // Связывание комбобокса cbCouriers с таблицей couriers из dataSet.
            //    comboBoxIngredients.DataSource = dataSet.Tables["ingredients"];
            //    comboBoxIngredients.DisplayMember = "_name";
            //    comboBoxIngredients.ValueMember = "id";
            //}
        }

        /// <summary>
        /// Заполнить комбобокс "Курьеры" в таблице "Заказы".
        /// </summary>
        private void FillCourierCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["courierId"]).DataSource =
                allCouriers;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["courierId"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["courierId"]).ValueMember =
                "id";
        }

        /// <summary>
        /// Сохранить изменения в таблице clients.
        /// </summary>
        private void buttonSaveClients_Click(object sender, EventArgs e)
        {
            //clientsAdapter.Update(dataSet, "clients");
            //dataSet.Tables["clients"].Rows.Clear();
            ////clientsAdapter = new NpgsqlDataAdapter("SELECT * FROM public.clients\r\nORDER BY id ASC", connectionString);
            ////clientsBuilder = new NpgsqlCommandBuilder(clientsAdapter);
            //clientsAdapter.Fill(dataSet, "clients");

            ////dataGridViewClients.Refresh();
            bool res = Validate();
            if (res)
            {
                dbContext.SaveChanges();
                dataGridViewClients.Refresh();
            }

        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            //using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            //{
            //    //NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            //    sqlConnection.Open();
            //    NpgsqlCommand sqlCommand =
            //        new NpgsqlCommand("SELECT p._name, p.description" +
            //                      " FROM pizza p inner join pizza_composition c on p.id = c.\"pizzaId\"" +
            //                      " inner join ingredients i on i.id = c.\"ingredientsId\" where i._name = \'"
            //                      + comboBoxIngredients.Text + "\'"
            //                      , sqlConnection);
            //    NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    DataTable dataTable = new DataTable("report1");
            //    dataTable.Columns.Add("Название");
            //    dataTable.Columns.Add("Описание");
            //    while (sqlDataReader.Read())
            //    {
            //        DataRow row = dataTable.NewRow();
            //        row["Название"] = sqlDataReader["_name"];
            //        row["Описание"] = sqlDataReader["description"];
            //        dataTable.Rows.Add(row);
            //    }
            //    sqlDataReader.Close();
            //    //sqlCommand.Dispose();
            //    //sqlConnection.Close();
            //    dataGridViewReport1.DataSource = dataTable;
            //}
        }

        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport2_Click(object sender, EventArgs e)
        {
            //using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            //{

            //    NpgsqlCommand sqlCommand = new NpgsqlCommand("select * from get_orders_by_month_year("+numericUpDown1.Value+","+numericUpDown2.Value+")", sqlConnection);
            //    //{
            //    //    Parameters =
            //    //    {
            //    //        new NpgsqlParameter(){Value = (int)numericUpDown1.Value},
            //    //        new NpgsqlParameter(){Value= (int)numericUpDown2.Value},
            //    //    }
            //    //};
            //    sqlConnection.Open();
            //    sqlCommand.Prepare();
            //    DataTable dataTable = new DataTable("report2");
            //    var sqlAdapter = new NpgsqlDataAdapter(sqlCommand);
            //    sqlAdapter.Fill(dataTable);
            //    //sqlCommand.Dispose();
            //    //sqlConnection.Close();
            //    dataGridViewReport2.DataSource = dataTable;


            //    ((DataGridViewComboBoxColumn)dataGridViewReport2.Columns["ClientId_"]).DataSource =
            //    dataSet.Tables["clients"];
            //    ((DataGridViewComboBoxColumn)dataGridViewReport2.Columns["ClientId_"]).DisplayMember =
            //        "first_name";
            //    ((DataGridViewComboBoxColumn)dataGridViewReport2.Columns["ClientId_"]).ValueMember =
            //        "id";

            //    ((DataGridViewComboBoxColumn)dataGridViewReport2.Columns["CourierId_"]).DataSource =
            //    dataSet.Tables["couriers"];
            //    ((DataGridViewComboBoxColumn)dataGridViewReport2.Columns["CourierId_"]).DisplayMember =
            //        "first_name";
            //    ((DataGridViewComboBoxColumn)dataGridViewReport2.Columns["CourierId_"]).ValueMember =
            //        "id";
            //}
        }

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {

            //ordersAdapter.Update(dataSet, "orders");

        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    AddPhoneForm f = new AddPhoneForm();
        //    f.comboBoxManuf.DataSource = allManufactures;
        //    f.comboBoxManuf.DisplayMember = "Name";
        //    f.comboBoxManuf.ValueMember = "Id";

        //    DialogResult result = f.ShowDialog(this);

        //    if (result == DialogResult.Cancel)
        //        return;

        //    Phone phone = new Phone();
        //    phone.manufacturerId = (int)f.comboBoxManuf.SelectedValue;
        //    phone.name = f.textBox1.Text;
        //    phone.cost = f.numericUpDown1.Value;
        //    phone.manufacturerId = (int)f.comboBoxManuf.SelectedValue;
        //    phone.description = f.textBox2.Text;
        //    dbcontext.Phones.Add(phone);
        //    dbcontext.SaveChanges();

        //    MessageBox.Show("Новый объект добавлен");
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    int index = getSelectedRow(dataGridViewPhones);
        //    if (index != -1)
        //    {
        //        int id = 0;
        //        bool converted = Int32.TryParse(dataGridViewPhones[0, index].Value.ToString(), out id);
        //        if (converted == false)
        //            return;

        //        Phone ph = dbcontext.Phones.Where(i => i.id == id).FirstOrDefault();
        //        if (ph != null)
        //        {
        //            AddPhoneForm f = new AddPhoneForm();
        //            f.comboBoxManuf.DataSource = allManufactures;
        //            f.comboBoxManuf.DisplayMember = "Name";
        //            f.comboBoxManuf.ValueMember = "Id";
        //            f.numericUpDown1.Value = ph.cost;
        //            f.comboBoxManuf.SelectedValue = ph.manufacturerId;
        //            f.textBox1.Text = ph.name;
        //            f.textBox2.Text = ph.description;

        //            DialogResult result = f.ShowDialog(this);

        //            if (result == DialogResult.Cancel)
        //                return;

        //            ph.cost = f.numericUpDown1.Value;
        //            ph.name = f.textBox1.Text;
        //            ph.description = f.Text;
        //            ph.manufacturerId = (int)f.comboBoxManuf.SelectedValue;

        //            dbcontext.SaveChanges();
        //            MessageBox.Show("Объект обновлен");
        //        }
        //    }
        //    else
        //        MessageBox.Show("Ни один объект не выбран!");
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
