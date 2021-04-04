using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace WinFormUI
{
    public partial class Dashboard : Form
    {

        List<string> products;
        List<string> prices;

       

        public Dashboard()
        {
            InitializeComponent();

            RebindDropdown();
        }

        public void RebindDropdown()
        {
            products = GetListOfProducts();
            productsDropdown.DataSource = null;
            productsDropdown.DataSource = products;

        }




        private void addButton_Click(object sender, EventArgs e)
        {

            string message = "Thank you for your order! Have a nice day!";
            string title = "Order complete!";
            MessageBox.Show(message, title);
        }




        private void databaseSectionGroup_Enter(object sender, EventArgs e)
        {

        }

        private void resultsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void subTotalValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void shippingValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            discountBox.Text = "";
            string subTotalvalueTXT = subTotalvalue.Text;
            string shippingValueTXT = shippingValue.Text;
            //Convert the strings into integer
            double subTotalValue = Convert.ToDouble(subTotalvalueTXT);
            double shippingVvalue = Convert.ToDouble(shippingValueTXT);
            shippingVvalue = 10;

            //Check the Sub-total value if the order will have or not free shipping
            if (subTotalValue > 150)
            {
                shippingVvalue = 0;
                string shippingVvalueString = Convert.ToString(shippingVvalue);
                shippingValue.Text = shippingVvalueString;
                totalText.Text = TotalAmount.Add((double)subTotalValue, (double)shippingVvalue).ToString();
            }
            else
            {
                shippingVvalue = 10;
                string shippingVvalueString = Convert.ToString(shippingVvalue);
                shippingValue.Text = shippingVvalueString;
                totalText.Text = TotalAmount.Add((double)subTotalValue, (double)shippingVvalue).ToString();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addNewItemButton_Click(object sender, EventArgs e)
        {

            string totalValueTXT = totalBoxPerProduct.Text;
            string pricelValueTXT = priceBox.Text;
            string subTotalvalueTXT = subTotalvalue.Text;

            double totalBoxValue = Convert.ToDouble(totalValueTXT);
            double subTotalValue = Convert.ToDouble(subTotalvalueTXT);
            double priceValue = Convert.ToDouble(pricelValueTXT);

            totalBoxValue = TotalAmount.TotalPriceOfaProduct((double)amountOfProduct.Value, (double)priceValue);


            string totalBoxValueString = Convert.ToString(totalBoxValue);
            totalBoxPerProduct.Text = totalBoxValueString;

            bool CheckAmount = TotalAmount.TotalAmountBigger((double)amountOfProduct.Value);

            if (CheckAmount == false)
            {
                string[] arr = new string[4];

                arr[0] = productsDropdown.SelectedItem.ToString();
                arr[1] = priceBox.Text;
                arr[2] = amountOfProduct.Text;
                arr[3] = totalBoxPerProduct.Text;

                ListViewItem lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);
                subTotalvalue.Text = TotalAmount.Add((double)totalBoxValue, (double)subTotalValue).ToString();
            }
            else
            {
                amountOfProduct.Value = 10;
                string message = "You can't add more than 10 " + productsDropdown.Text;
                string title = "Amoung Warning";
                MessageBox.Show(message, title);

            }


        }


        private void productsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (productsDropdown.SelectedItem.ToString() == "Soroci BB Cream 30ML")
            {
                priceBox.Text = "26.99";
                totalBoxPerProduct.Text = "26.99";
            }
            else if (productsDropdown.SelectedItem.ToString() == "Thank You Farmer CC Cream 40ML")
            {
                priceBox.Text = "30.99";
                totalBoxPerProduct.Text = "30.99";
            }
            else if (productsDropdown.SelectedItem.ToString() == "Thank you Farmer Primer 40ML")
            {
                priceBox.Text = "25.99";
                totalBoxPerProduct.Text = "25.99";
            }
            else if (productsDropdown.SelectedItem.ToString() == "Thank you Farmer BB Cream 40ML")

            {
                priceBox.Text = "27.99";
                totalBoxPerProduct.Text = "27.99";
            }

        }


        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();
            products.Add("Soroci BB Cream 30ML");
            products.Add("Thank You Farmer CC Cream 40ML");
            products.Add("Thank you Farmer Primer 40ML");
            products.Add("Thank you Farmer BB Cream 40ML");
            return products;
        }
        List<string> GetListOfPrices()
        {
            List<string> prices = new List<string>();
            prices.Add("26.99");
            prices.Add("30.99");
            prices.Add("25.99");
            prices.Add("27.99");
            return prices;
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)

                    {
                        string totalFromListST = (listView1.Items[i].SubItems[3]).Text;
                        double totalFromList = Convert.ToDouble(totalFromListST);

                        string subtotalValueTXT = subTotalvalue.Text;
                        double SubtotalValue = Convert.ToDouble(subtotalValueTXT);
                        double subTotalfromList = TotalAmount.RemoveItem((double)SubtotalValue, (double)totalFromList);
                        string subTotalfromListString = Convert.ToString(subTotalfromList);
                        subTotalvalue.Text = subTotalfromListString;

                        listView1.Items[i].Remove();


                    }
                }
            }
        }

        private void discountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyDiscountButton_Click(object sender, EventArgs e)
        {
            if (discountBox.Text != "")
            {

                string discountBoxTXT = discountBox.Text;
                decimal discountBoxValue = Convert.ToDecimal(discountBoxTXT);
                string totalValueTXT = totalText.Text;
                decimal totalValue = Convert.ToDecimal(totalValueTXT);
                decimal totalValueAfterDiscount;

                if (discountBoxValue == 15)
                {
                    totalValueAfterDiscount = Math.Round((TotalAmount.DicountCalc((decimal)totalValue, 15)), 2);
                    string totalValueAfterDiscountString = Convert.ToString(totalValueAfterDiscount);
                    totalText.Text = totalValueAfterDiscountString;
                }
                else
                {
                    string message = "Sorry! For the moment, we do not have that discount!";
                    string title = "Warning";
                    MessageBox.Show(message, title);
                }
            }
            else
            {
                string message = "Please write the dicount in the box!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }
    }
}
