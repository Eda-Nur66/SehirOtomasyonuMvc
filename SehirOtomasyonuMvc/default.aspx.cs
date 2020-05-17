using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        object kullanici = Session["KullaniciAdi"];

        if (kullanici == null)
        {
            lblKullaniciAdi.Text = "Sessiondan gelen değer boştur.";
        }
        else
        {
            lblKullaniciAdi.Text = "Hoşgeldiniz sayın " + kullanici.ToString();
            btnOturumAc.Visible = false;
        }


    }

    protected void btnCikis_Click(object sender, EventArgs e)
    {

        Session.Abandon();

        Response.Redirect(Request.RawUrl);

    }

    protected void btnOturumAc_Click(object sender, EventArgs e)
    {

        Response.Redirect("/giris.aspx");

    }


}