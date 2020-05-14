using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using SehirOtomasyonuMvc.Models;

namespace SehirOtomasyonuMvc.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        /*SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataAdapter dr;*/
        [HttpGet]
        // GET: Admin/Account
        public ActionResult Login()
        {
            return View();
        }
        /*void connectionString()
        {
            con.ConnectionString = "data source =SQLEXPRESS; database=SehirOtomasyonDbMvc; integrated security=SSPI;";
        }
        public ActionResult Verify(Acount acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "";
            com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
            }
            else
            {
                con.Close();
            }


          
        }*/
       
            
    }
}