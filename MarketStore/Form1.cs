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

            //Validation
            try
            {
                //Set the values in the class
                purchase.setTurnover(double.Parse(textBox1.Text));
                purchase.setValue(double.Parse(textBox2.Text));          
            }
            catch
            {
                //Error message for incorrect input
                label11.Text = "Enter valid value!";
                return;
            }
            
            purchase.setCard(comboBox1.Text);//Set the card     
            purchase.SetDiscount();//Calculate the discount  

            label11.Text = "";//Clear the error message
            label9.Text = "Discount rate: " + (purchase.getDiscount()).ToString()+"%";//Print the discount rate
            label3.Text = String.Format("Purchase value: $" + "{0:0.00}", purchase.getValue());//Print the purchase value
            label4.Text = String.Format("Discount: $" + "{0:0.00}", purchase.DiscountCalculation());//Print the discount
            label5.Text = String.Format("Total: $" + "{0:0.00}", purchase.Total());//Print the total price
            label12.Text = "Card type: "+ purchase.getCard();//Print the card type         
        }
    }    
}
