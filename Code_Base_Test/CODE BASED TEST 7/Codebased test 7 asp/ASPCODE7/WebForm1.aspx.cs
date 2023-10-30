using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPCODE7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void buttonCheck_Click(object sender, EventArgs e)
        {
            string Name = Textname.Text;
            string FamilyName = Textfamilyname.Text;
            string Address = Textaddress.Text;
            string City = Textcity.Text;
            string ZipCode = Textzipcode.Text;
            string Phone = Textphoneno.Text;
            string Email = Textemail.Text;

            if (Name == FamilyName)
            {
                lblResult.Text = "Name should be different from the Family Name.";
            }
            else if (Address.Length < 2)
            {
                lblResult.Text = "Address must have at least 2 letters.";
            }
            else if (City.Length < 2)
            {
                lblResult.Text = "City must have at least 2 letters.";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(ZipCode, @"^\d{5}$"))
            {
                lblResult.Text = "Zip Code must have 5 digits.";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Phone, @"^\d{2}-\d{7}$|^\d{3}-\d{7}$"))
            {
                lblResult.Text = "Phone must be in the format XX-XXXXXXX or XXX-XXXXXXX.";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"))
            {
                lblResult.Text = "Invalid email address.";
            }
            else
            {
                lblResult.Text = "Validation passed!";
            }

        }
    }
}






