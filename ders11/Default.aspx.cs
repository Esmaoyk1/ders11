using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ders11 {
	public partial class Default : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			if(!Page.IsPostBack) {
                bindUrunler();
			}
        }

        string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ders11; Integrated Security=True";
        protected void bindUrunler() {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM urunler", con);

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(table);

            DropDownList1.DataSource = table;
            DropDownList1.DataValueField = "id"; 
            DropDownList1.DataTextField = "adi";
            DropDownList1.DataBind();

        }

		
        // Satın al
        protected void Button1_Click(object sender, EventArgs e) {

            string sqlCumlecik = "Insert INTO siparisler (urun_id,adet,tarih) values('" +
                DropDownList1.SelectedValue
                + "','" +
                TextBox1.Text
                + "','" +
                DateTime.Now.ToString("yyyy-MM-dd")
                + "')";


            using(SqlConnection con = new SqlConnection(connectionString)) {
                con.Open();

                using(SqlCommand cmd = new SqlCommand(sqlCumlecik, con)) {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    Label3.Text = "Sipariş Verildi.";
                }
            }

        }
	}
}