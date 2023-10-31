using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Ass_1
{
    public partial class ass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the dropdown list with items
                ddlItems.Items.Add(new ListItem("Cadbury", "c.png"));
                ddlItems.Items.Add(new ListItem("dairymilk", "d1.png"));
                ddlItems.Items.Add(new ListItem("kitkat", "k1.png"));
                ddlItems.Items.Add(new ListItem("temptation", "t1.png"));
              
            }
        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the image URL based on the selected item
            string selectedImageUrl = ddlItems.SelectedItem.Value;
            imgItem.ImageUrl = $"IMAGES/{selectedImageUrl}";
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            // Get the cost of the selected item (You can replace this with your actual cost logic)
            string selectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            lblCost.Text = $"Cost of {selectedItem}: {cost}";
        }

        // You can implement your own cost retrieval logic here
        private string GetItemCost(string item)
        {
            // Replace this with your cost retrieval logic
            switch (item)
            {
                case "Cadbury":
                    return "Rs 60";
                case "dairymilk":
                    return "Rs 200";
                case "kitkat":
                    return "40";
                case "temptation":
                    return "150";
              
                default:
                    return "N/A";
            }
        }

    }
}
        