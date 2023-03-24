using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFBook : System.Web.UI.Page
    {
        private string name_book;
        private int pag;
        private int chapters;
        private string date_lounch;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
            TBNameB.Text = " ";
            TBPag.Text = " ";
            TBChapeters.Text = " ";
            TBDate_lounch.Text = " ";
        }

        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            name_book = TBNameB.Text;
            pag = Convert.ToInt32(TBPag.Text);
            chapters = Convert.ToInt32(TBChapeters.Text);
            date_lounch = TBDate_lounch.Text;

            Book objBook = new Book(name_book,pag,chapters,date_lounch);
            Lblmsj35.Text = objBook.initbook();
            LimpiarCajas();

        }
    }
}