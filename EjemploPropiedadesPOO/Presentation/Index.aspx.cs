using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{

    public partial class Index : System.Web.UI.Page
    {/*
      * variables globales
      */
        
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

       

        protected void LBCar_Click(object sender, EventArgs e)
        {
            //Redirecciona al Formulario WFcar
            Response.Redirect("WFCar.aspx");
        }

        protected void LBPhone_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFPhone.aspx");
        }

        protected void LBPerson_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFPerson.aspx");
        }

        protected void LBScoccer_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFSoccer.aspx");
        }

        protected void LBHouse_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WFHouse.aspx");
        }

        protected void LBCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFCard.aspx");
        }

        protected void LBBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFBook.aspx");
        }

        protected void LBLaptop_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFLaptop.aspx");
        }
    }
}