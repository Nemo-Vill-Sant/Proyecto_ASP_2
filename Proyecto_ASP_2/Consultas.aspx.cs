using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


namespace Proyecto_ASP_2
{
    public partial class Consultas : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=proyecto;User Id=root;password=''");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}