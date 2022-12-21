using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using System.Diagnostics;
using Task4.Logic;
using Task4.Models;

namespace Task4
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/login.aspx");
            }

            string rawId = Request.QueryString["FoodID"];
            int foodId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out foodId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a FoodID.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a FoodID.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}