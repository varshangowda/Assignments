using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class Validator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string Name = textName.Text;
            string FamilyName = textFamilyName.Text;
            string Address = textAddress.Text;
            string City = textCity.Text;
            string ZipCode = etxtZipCode.Text;
            string Phone = textPhone.Text;
            string Email = textEmail.Text;

            if (name == familyName)
            {
                lblResult.Text = "Name should be different from the Family Name.";
            }
            else if (address.Length < 2)
            {
                lblResult.Text = "Address must have at least 2 letters.";
            }
            else if (city.Length < 2)
            {
                lblResult.Text = "City must have at least 2 letters.";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(zipCode, @"^\d{5}$"))
            {
                lblResult.Text = "Zip Code must have 5 digits.";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{2}-\d{7}$|^\d{3}-\d{7}$"))
            {
                lblResult.Text = "Phone must be in the format XX-XXXXXXX or XXX-XXXXXXX.";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"))
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
