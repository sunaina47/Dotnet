using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeInfo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblResult.Text = DropDownList1.Text;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Software_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void LblFullResult_Click(object sender, EventArgs e)
        {
            LblFullResult.Text = TxtName.Text + " " + LblResult.Text;
            if (RdoHR.Checked == true)
            {
                LblResult.Text += " HR";
            }
            else if (RdoAccounts.Checked == true)
            {
                LblFullResult.Text += " Accounts";
            }
            else if (RdoSoftware.Checked == true)
            {
                LblFullResult.Text += " Software";
            }

            if(ChkBE.Checked == true)
            {
                LblFullResult.Text += " B.E";
            }
            else if (ChkMBA.Checked == true)
            {
                LblFullResult.Text += " MBA";
            }
            if (ChkPHD.Checked == true)
            {
                LblFullResult.Text += " PHD";
            }
        }
    }
}