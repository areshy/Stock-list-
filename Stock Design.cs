
using Medicine;
using System.Data;
using System.Data.SqlClient;

namespace Stock
{
    public partial class Form1 : Form
    {
        function func = new function();
        string search;

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HJJGVJB\\SQLEXPRESS;Initial Catalog=medicinelist;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            search = "SELECT * from Table1";
            DataSet ds = func.getData(search);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            datagrid.AutoGenerateColumns = false;
            datagrid.DataSource = dt;
            func.setData(search, "Medicine details listed.");


        }
    }
}