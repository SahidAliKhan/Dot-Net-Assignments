using Bank_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bank_BAL;

namespace _3rdOctMasterPage
{
    public partial class InterestRate : System.Web.UI.Page
    {
        //protected override void OnPreInit(EventArgs e)
        //{
        //    base.OnPreInit(e);
        //    this.MasterPageFile = "BankApp.Master";
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BankProds prods1 = new BankProds();
                List<Products> cprods = new List<Products>(); cprods = prods1.CalculatingInterest();
                foreach (var item in cprods)
                {
                    Products p = new Products();
                    p.Prodname = item.Prodname;
                    p.InterestRates = item.InterestRates;
                    DropDownList2.Items.Add
                    (new ListItem { Text = p.Prodname, Value = p.InterestRates.ToString() });

                }
            }


            BankProds prods = new BankProds();
            List<string> names = new List<string>();
            names = prods.ProductNames();
            DropDownList1.DataSource = names;
            DropDownList1.DataBind();

            List<Products> products = new List<Products>();
            products = prods.GetProducts();

            GridView1.DataSource = products;
            GridView1.DataBind();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "25Days")
            {
                txtinterest.Text = "2%";
            }
            else if(DropDownList1.SelectedValue == "50Days")
            {
                txtinterest.Text = "2.5%";
            }
            else if (DropDownList1.SelectedValue == "365Days")
            {
                txtinterest.Text = "6%";
            }
            else if (DropDownList1.SelectedValue == "2Years")
            {
                txtinterest.Text = "8.7%";
            }
        }

        protected void txtinterest_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int rate = Convert.ToInt32
                (DropDownList2.SelectedValue);
            double amt = Convert.ToInt32(TextBox1.Text);
            double tenure = Convert.ToInt32(TextBox2.Text);
            TextBox4.Text = rate.ToString();
            double cAmt = (amt * tenure * rate) / 100;
            TextBox3.Text = cAmt.ToString();
        }
    }
}