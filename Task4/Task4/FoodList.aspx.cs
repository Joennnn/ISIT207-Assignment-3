using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task4.Models;
using System.Web.ModelBinding;

namespace Task4
{
    public partial class FoodList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }
        public IQueryable<food> GetFoods([QueryString("id")] int? categoryId, [RouteData] string categoryName)
        {
            var _db = new Task4.Models.foodcontext();
            IQueryable<food> query = _db.Food;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            if (!String.IsNullOrEmpty(categoryName))
            {
                query = query.Where(p =>
                                    String.Compare(p.Category.CategoryName,
                                    categoryName) == 0);
            }
            return query;
        }
    }
}