using System;
using System.Web.UI;

namespace HNVPharmacyStockInfo
{
    public partial class _Inf : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            view_StockInfo.Visible = false;
            view_StockInfo.Font.Size = System.Web.UI.WebControls.FontUnit.XSmall;
        }


        protected void txtProductName_TextChanged(object sender, EventArgs e)
        {
            cmbProduct.DataSource = SqlDataSource10;
            cmbProduct.DataBind();

            view_StockInfo.DataSource = SqlDataSource2; //by id Product           
            view_StockInfo.Visible = true;
            view_StockInfo.DataBind();
        }

        protected void txtProvider_TextChanged(object sender, EventArgs e)
        {
            cmbProvider.DataSource = SqlDataSource11;
            cmbProvider.DataBind();

            view_StockInfo.DataSource = SqlDataSource3;//by id Supplier          
            view_StockInfo.Visible = true;
            view_StockInfo.DataBind();
        }



        protected void butSearchByBarCode_Click(object sender, EventArgs e)
        {
            view_StockInfo.DataSource = SqlDataSource1; //by code barre           
            view_StockInfo.Visible = true;
            view_StockInfo.DataBind();
        }

        protected void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            view_StockInfo.DataSource = SqlDataSource2; //by id Product           
            view_StockInfo.Visible = true;
            view_StockInfo.DataBind();

        }

        protected void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            view_StockInfo.DataSource = SqlDataSource3;//by id Supplier          
            view_StockInfo.Visible = true;
            view_StockInfo.DataBind();
        }

        protected void butSearchByProvider_Click(object sender, EventArgs e)
        {
            view_StockInfo.DataSource = SqlDataSource4;//by Supplier  name        
            view_StockInfo.Visible = true;
            view_StockInfo.DataBind();
        }

        protected void butSearchByName_Click(object sender, EventArgs e)
        {
            view_StockInfo.DataSource = SqlDataSource5; // by product name        
            view_StockInfo.Visible = true;
            view_StockInfo.DataBind();
        }
    }
}