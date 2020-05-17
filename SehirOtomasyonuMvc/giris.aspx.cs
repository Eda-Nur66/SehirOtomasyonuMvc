using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class giris : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        // Session.Add()
        // Session.Abandon()
        // Session.Timeout

        object kullanici = Session["KullaniciAdi"];

        if (kullanici != null)
        {
            Response.Redirect("/default.aspx");
        }
        else
        {

        }

    }

    protected void btnGiris_Click(object sender, EventArgs e)
    {

        Session.Timeout = 120;



        if (txtKullaniciAdi.Text == "admin" & txtSifre.Text == "1234")
        {

            Session.Add("KullaniciAdi", txtKullaniciAdi.Text);

            Response.Redirect("/Admin/Home/Index");

        }
        else
        {
            lblGirisDurum.Text = "Hatalı giriş.";
        }

        //Session.Abandon();

    }

}