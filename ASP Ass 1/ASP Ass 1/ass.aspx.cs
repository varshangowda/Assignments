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
                
                ddlItems.Items.Add(new ListItem("nokia", "nokia.png"));
                ddlItems.Items.Add(new ListItem("oppo reno6", "oppo reno6.png"));
                ddlItems.Items.Add(new ListItem("redmi pro", "redmi pro.png"));
                ddlItems.Items.Add(new ListItem("iphone 15 pro", "iphone 15 pro.png"));
                ddlItems.Items.Add(new ListItem("samsung gold fold", "samsung gold fold.png"));
                ddlItems.Items.Add(new ListItem("vivo v27 pro", "vivo v27 pro.png"));


            }
        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            string selectedImageUrl = ddlItems.SelectedItem.Value;
            imgItem.ImageUrl = $"IMAGES/{selectedImageUrl}";
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            string selectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            lblCost.Text = $"Cost of {selectedItem}: {cost}";
           
        }


        private string GetItemCost(string item)
        {
            
            switch (item)
            {
                case "nokia":
                    return "Rs 1749";
                case "oppo reno6":
                    return "Rs15999";
                case "redmi pro":
                    return "24999";
                case "iphone 15 pro":
                    return "199900";
                case "samsung gold fold":
                    return "59,99";
                case "vivo v27 pro":
                    return "36,999";

                default:
                    return "N/A";
            }
        }

    }
}
        