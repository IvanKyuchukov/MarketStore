using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }       

        private void button1_Click(object sender, EventArgs e)
        {           
            Purchase purchase = new Purchase();

            try
            {
                purchase.setTurnover(double.Parse(textBox1.Text));
                purchase.setValue(double.Parse(textBox2.Text));          
            }
            catch
            {
                label11.Text = "Enter valid value!";
                return;
            }

            purchase.setCard(comboBox1.Text);
            purchase.SetDiscount();   

            label11.Text = "";
            label9.Text = "Discount rate: " + (purchase.getDiscount()).ToString()+"%";
            label3.Text = String.Format("Purchase value: $" + "{0:0.00}", purchase.getValue());
            label4.Text = String.Format("Discount: $" + "{0:0.00}", purchase.DiscountCalculation());
            label5.Text = String.Format("Total: $" + "{0:0.00}", purchase.Total());
            label12.Text = "Card type: "+ purchase.getCard();           
        }
    }    
}
