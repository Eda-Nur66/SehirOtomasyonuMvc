﻿using System;
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
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        // GET: Admin/Account
        public ActionResult Login()
        {
            return View();
        }
        //void connectionString()
        //{
        //    con.ConnectionString = "data source =./SQLEXPRESS; database=SehirOtomasyonDbMvc; Integrated Security=true;";
        //}
        //[HttpPost]
        //public ActionResult Verify(Account acc)
        //{
        //    connectionString();
        //    con.Open();
        //    com.Connection = con;
        //    com.CommandText = "select * from tbl_admin where username" + acc.Name + "and password=" + acc.Password + "'";
        //    com.ExecuteReader();
        //    if (dr.Read())
        //    {

        //        con.Close();
        //        return View("Create");
        //    }
        //    else
        //    {
        //        con.Close();
        //        return View("Error");
        //    }


        }
    }
