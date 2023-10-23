using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Craving
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void BtnResult_Click(object sender, EventArgs e)
        {
            if (RdoPizza.Checked == true)
            {
                LblResult.Text = "You Chose Pizza";
                ImgFood.ImageUrl = "images/pizza.jpg";
            }
            else if (RdoBurger.Checked == true)
            {
                LblResult.Text = "You Chose Burger";
                ImgFood.ImageUrl = "images/burger.jpg";
            }
            if (RdoPasta.Checked == true)
            {
                LblResult.Text = "You Chose Pizza";
                ImgFood.ImageUrl = "images/pasta.png";
            }
        }

        protected void BtnFood_Click(object sender, EventArgs e)
        {
            foreach(ListItem x in CheckBoxList1.Items)
            {
                if(x.Selected == true)
                {
                    LblFood.Text += "You picked " + x.Value + "</br>";
                }          
            }
        }
    }
}