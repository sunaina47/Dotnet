using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnArea_Click(object sender, EventArgs e)
        {
            double len, wid;
            double area;
            len = double.Parse(TextLength.Text);
            wid = double.Parse(TextWidth.Text);
            
            area = AreaMethod(len, wid);
            LblResult.Text = area.ToString();
        }
        private double AreaMethod(double l, double w)
        {
            double a;
            a = l * w;
            return a;
        }
    }
}