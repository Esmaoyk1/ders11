using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ders11 {
	public partial class detaylar : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			if(!Page.IsPostBack) {
				detaylari_goster();
			}
		}

		void detaylari_goster() {
			string siparis_id = Request.QueryString[0];

			string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ders11; Integrated Security=True";
			using(SqlConnection con = new SqlConnection(connectionString)) {
				con.Open();
				using(SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM siparisler WHERE id="+siparis_id, con)) {
					DataSet ds = new DataSet();
					da.Fill(ds);

					var row = ds.Tables[0].Rows[0];

					lblID.Text += row["id"].ToString();
					lblUrunID.Text += row["urun_id"].ToString();
					lblUrunAdet.Text += row["adet"].ToString();
					lblTarih.Text += row["tarih"].ToString();
					lblKargoTarih.Text += row["kargo_tarih"].ToString();
					lblAsama.Text += row["asama"].ToString();
					
				}
			}
		}
	}
}