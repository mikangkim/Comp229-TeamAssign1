﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_TeamAssign
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {


                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Login"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from users where UserName='" + txtName.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    Response.Write("User already Exists");

                }
                conn.Close();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Guid newGUID = Guid.NewGuid();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Login"].ConnectionString);
                conn.Open();
                string insertQuery = "insert into users (id, UserName, Email, Password, Country) values (@id, @Uname, @email, @password, @country)";
                SqlCommand com = new SqlCommand(insertQuery, conn);

                com.Parameters.AddWithValue("@id", newGUID.ToString());
                com.Parameters.AddWithValue("@Uname", txtName.Text);
                com.Parameters.AddWithValue("@email", txtEmail.Text);
                com.Parameters.AddWithValue("@password", txtPwd.Text);
                com.Parameters.AddWithValue("@country", ddlCountry.SelectedItem.ToString());

                com.ExecuteNonQuery();
                //Response.Redirect("default.aspx");
                Response.Write("Registration is succesful");

                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());

            }



        }
    }
}