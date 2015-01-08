using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class Kayit : System.Web.UI.Page
    {
        public SqlConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            username.Attributes["placeholder"] = "Kullanıcı Adı";
            password.Attributes["placeholder"] = "Parola";

            kayit_username.Attributes["placeHolder"] = "Kullanıcı Adınız";
            kayit_password.Attributes["placeHolder"] = "Parolanız";
            kayit_name.Attributes["placeHolder"] = "Adınız";
            kayit_surname.Attributes["placeHolder"] = "Soyadınız";
        }

        protected void kayit_button_Click(object sender, EventArgs e)
        {
            mesaj.CssClass = "mesaj";
           
            try
            {

                baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand kayit = new SqlCommand("INSERT INTO users(name,surname,username,password) VALUES(@n, @s, @u, @p)", baglanti);
                kayit.Parameters.AddWithValue("@n", kayit_name.Text);
                kayit.Parameters.AddWithValue("@s", kayit_surname.Text);
                kayit.Parameters.AddWithValue("@u", kayit_username.Text);
                kayit.Parameters.AddWithValue("@p", kayit_password.Text);
                kayit.ExecuteNonQuery();
                mesaj.Text = "Başarıyla Kayıt Oldunuz. Aferin.";
            }

            catch (SqlException hata)
            {
                mesaj.Text = "Kayıt olma işleminiz berbat bir şekilde sonuçlandı.";
            }
            finally
            {
                baglanti.Close();
                kayit_name.Text = "";
                kayit_surname.Text = "";
                kayit_username.Text = "";
                kayit_password.Text = "";

            }

        }
    }
}