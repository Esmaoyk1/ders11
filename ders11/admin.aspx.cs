using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ders11 {
	public partial class admin : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			if(!Page.IsPostBack) {
				goster();
			}
		}
		string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ders11; Integrated Security=True";

		void goster() {
			using(SqlConnection con = new SqlConnection(connectionString)) {
				con.Open();
				using(SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM siparisler", con)) {
					DataSet ds = new DataSet();
					da.Fill(ds);
					grdSiparisler.DataSource = ds.Tables[0];
					grdSiparisler.DataBind();
				}
			}
		}

		protected void grdSiparisler_RowDataBound(object sender, GridViewRowEventArgs e) {
			if(e.Row.RowType == DataControlRowType.DataRow) {
				string siparis_id = DataBinder.Eval(e.Row.DataItem, "id").ToString();
				string kargoda = DataBinder.Eval(e.Row.DataItem, "kargoda").ToString();
				string asama = DataBinder.Eval(e.Row.DataItem, "asama").ToString();


				var btn_iptal = ((Button)e.Row.FindControl("btnIptal"));

				if(asama == "Tamamlandı") {
					e.Row.BackColor = System.Drawing.Color.Green;
					btn_iptal.Visible = false;
				}
				else if(asama == "Iptal") {
					e.Row.BackColor = System.Drawing.Color.OrangeRed;
					btn_iptal.Visible = false;
				}


				if (kargoda=="True") {
					btn_iptal.Visible = false;
				}


				((Button)e.Row.FindControl("btnDetay")).CommandArgument = siparis_id;
				((Button)e.Row.FindControl("btnIptal")).CommandArgument = siparis_id;
			}
		}

		protected void btnDetay_Click(object sender, EventArgs e) {
			string siparis_id = ((Button)sender).CommandArgument;
			Response.Redirect("detaylar.aspx?"+ siparis_id.ToString());
		}

		protected void btnIptal_Click(object sender, EventArgs e) {
			string siparis_id = ((Button)sender).CommandArgument;

			string sqlCumlecik = "UPDATE siparisler SET asama='Iptal' WHERE id=" + siparis_id;
			using(SqlConnection con = new SqlConnection(connectionString)) {
				con.Open();

				using(SqlCommand cmd = new SqlCommand(sqlCumlecik, con)) {
					cmd.CommandType = CommandType.Text;
					cmd.ExecuteNonQuery();
					goster();
					
				}
			}


		}
	}
}