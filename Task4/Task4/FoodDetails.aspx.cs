using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task4.Models;
using System.Web.ModelBinding;
using System.Data.SqlClient;

namespace Task4
{
    public partial class FoodDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }
        public IQueryable<food> GetFoods([QueryString("foodID")] int? foodId, [RouteData] string foodName)
        {
            var _db = new Task4.Models.foodcontext();
            IQueryable<food> query = _db.Food;
            if (foodId.HasValue && foodId > 0)
            {
                query = query.Where(p => p.FoodID == foodId);
            }
            else if (!String.IsNullOrEmpty(foodName))
            {
                query = query.Where(p =>
                          String.Compare(p.FoodName, foodName) == 0);
            }
            else
            {
                query = null;
            }
            return query;
        }

        protected void foodDetail_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}