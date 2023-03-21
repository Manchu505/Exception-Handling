using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABV_Calc;





public partial class Form1 : Form
{
    decimal num1;
    decimal num2;
    decimal num3 = (decimal)76.08;
    decimal num4 = (decimal)1.775;
    decimal num5 = (decimal).794;
    decimal num6 = (decimal)131.25;
    decimal num7 = (decimal)258.6;
    decimal num8 = (decimal)258.2;
    decimal num9 = (decimal)227.1;
    decimal num10;
    decimal num11;


    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        // decimal num1 = decimal.Parse(inputOG.Text);
        //decimal num2 = decimal.Parse(inputFG.Text);
        // decimal num3 = (decimal)76.08;
        //decimal num4 = (decimal)1.775;
        //decimal num5 = (decimal).794;
        //decimal num6 = (decimal)131.25;
        //  if (decimal.TryParse(inputOG.Text, out num1))

        // else
        //  MessageBox.Show("Enter Valid Readings"); 

        if (radioPlato.Checked == true && decimal.TryParse(inputOG.Text, out num1) && decimal.TryParse(inputFG.Text, out num2))
        {
            //=1+(A2/(258.6 - ((A2/258.2)*227.1)))
            //decimal.TryParse(inputOG.Text, out num1);
            //decimal.TryParse(inputFG.Text, out num2);
            //decimal.Parse(inputOG.Text);
            //decimal.Parse(inputFG.Text);
            //decimal num10 = (1 + (num1 / (num7 - ((num1 / num8) * num9))));
            //decimal num11 = (1 + (num2 / (num7 - ((num2 / num8) * num9)))); 
            if(num1 <2)

            {
                MessageBox.Show("Input OG in Plato");
            }
            else if(num2 <2) 
            { 
                MessageBox.Show("Input FG in Plato"); 
            }

            num10 = 1 + (num1 / (num7 - ((num1 / num8) * num9)));
            num11 = 1 + (num2 / (num7 - ((num2 / num8) * num9)));
        }

        /*try
        {
            num1 = decimal.("N2");
            // Decimal.Round(num1, 2);

            //countdecimalplaces(num1 < 3);
        }
        catch
        {
            MessageBox.Show("Enter a Valid Plato");

        }*/
        /*if (Decimal.Round(num1, 1) != num1)
        {
            num10 = 1 + (num1 / (num7 - ((num1 / num8) * num9)));

        }
        else if (Decimal.Round(num2, 1) != num2)
        {
            num11 = 1 + (num2 / (num7 - ((num2 / num8) * num9)));
        }
        else
            MessageBox.Show("Enter a Valid Plato Reading");
    }
        */

        else if (radioPlato.Checked == false && decimal.TryParse(inputOG.Text, out num1) && decimal.TryParse(inputFG.Text, out num2))
        {
            //decimal.TryParse(inputOG.Text, out num1);
            //decimal.TryParse(inputFG.Text, out num2);
            //decimal.Parse(inputOG.Text);
            //decimal.Parse(inputFG.Text);
           
        }

        else
        {
            MessageBox.Show("Enter Valid Readings");
        }

        if (radioStandard.Checked == true && radioSG.Checked == true)
        {
            //decimal.TryParse(inputOG.Text, out num1);
            //decimal.TryParse(inputFG.Text, out num2);
            decimal sum1 = (num1 - num2) * num6;
            label10.Text = sum1.ToString("N2") + ("%");
          
        }
        else if (radioAlternate.Checked == true && radioSG.Checked == true)
        {
            //decimal.TryParse(inputOG.Text, out num1);
            //decimal.TryParse(inputFG.Text, out num2);
            decimal sum2 = (num3 * (num1 - num2) / (num4 - num1)) * (num2 / num5);
            label10.Text = sum2.ToString("N2") + ("%");
        }

        else if (radioStandard.Checked == true && radioSG.Checked == false)
        {
            //decimal.TryParse(inputOG.Text, out num1);
            //decimal.TryParse(inputFG.Text, out num2);
            decimal sum4 = (num10 - num11) * num6;

            label10.Text = sum4.ToString("N2") + ("%");
        }

        else // (radioAlternate.Checked == true && radioSG.Checked == false)
        {
            //decimal.TryParse(inputOG.Text, out num1);
            //decimal.TryParse(inputFG.Text, out num2);
            decimal sum3 = (num3 * (num10 - num11) / (num4 - num10)) * (num11 / num5);
            label10.Text = sum3.ToString("N2") + ("%");
        }
        
    }
        private void button3_Click(object sender, EventArgs e)
    {   
             this.Close();
    }
        private void button2_Click_1(object sender, EventArgs e)
{ 
                inputFG.Text = "";
                inputOG.Text = "";
                label10.Text = "";

    }

  
    

    }



