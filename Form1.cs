using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MegaNumber 
{
    
    public partial class Form1 : Form
    {
        const string strkey = "Software\\MedProgramming\\Super_Calculator";
        public Form1()
        {
            InitializeComponent();

        }
       
        public double Pow(double n, double m)
        {
            double result = 0;
            int coun;
            for (coun = 0; coun < m; coun++)
            {
                result = n*=n;
            }
            //result = n;
            return result;
        }

        public long Fac(int n)
        {
            long resul;
            if (n == 1)
                return 1;

            else
                resul = Fac(n - 1) * n;

            return resul;

        }
         
      //global variables...

        int m;
        int t;
        double first2;
        double second2;    
        double res = 0;
        string oper1; 
        int j, l;
        double opl = 0;
        int count1 = 0;
        int coun = 0;
        int  radiocoun = 0;
        double coutval;
        double add;
        double sub;
        double mul;
        double div;
        double mod;
        double pow;
        long  fac;
        int add_count;
        int mul_count;
        int sub_count;
        int div_count;
        int mod_count;
        int pow_count;
        int fac_count;
        int global_count = 0;
        int new_global_count = 0;
        int som1;
        bool isNumber = false;
        bool isNumber2 = false;
        double outputValue = 0;


        private void call_Click(object sender, EventArgs e)
        {
            isNumber = double .TryParse (first .Text, out outputValue );
            isNumber2 = double.TryParse(second.Text, out outputValue);
            try
            {

                if (choice.Text == "Addition -> [ + ]")
                {
                    if (counterradio.Checked)
                    {

                        coutval = double.Parse(counter.Text);
                        first2 =  double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        for (l = 0; l < coutval; l++)
                        {

                            opl = first2 + second2;
                        }
                        res1.Text = "Result : " + opl * coutval;
                        res2.Text = "Time Applied : " + coutval + " times!";
                    }
                    else
                    {
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        oper1 = string.Format(oper.Text);

                        for (j = 0; j < oper1.Length; j++)
                        {

                            if (oper1[j] == '+')
                            {
                                count1++;
                                res = first2 + second2;
                                res1.Text = "The result :" + res * count1;
                                res2.Text = "Time applied :" + count1 + " times!";

                            }

                        }
                        if (oper.TextLength == 0)
                        {
                            MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (oper1.Length > count1)
                        {
                            MessageBox.Show("the operator field is contain some uncode charecter!\nNotice that calcilation will aplly only on Addition Operator :'+'", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }

                    }
                    count1 = 0;
                }
                else if (choice.Text == "Multiplication -> [ X ]")
                {

                    if (counterradio.Checked)
                    {
                        coutval = double.Parse(counter.Text);
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        for (l = 0; l < coutval; l++)
                        {
                            opl = first2 * second2;
                        }
                        res1.Text = "Result : " + opl * coutval;
                        res2.Text = "Time Applied : " + coutval + " times!";
                    }
                    else
                    {
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        oper1 = string.Format(oper.Text);

                        // for (int k = 0; k < 4;k++ )
                        for (j = 0; j < oper1.Length; j++)
                        {

                            if (oper1[j] == '*')
                            {
                                count1++;
                                res = first2 * second2;
                                res1.Text = "The result :" + res * count1;
                                res2.Text = "Time applied :" + count1 + " times!";

                            }

                        }
                        if (oper.TextLength == 0)
                        {
                            MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (oper1.Length > count1)
                        {
                            MessageBox.Show("the operator field is contain some uncode charecter!\nNotice that calcilation will aplly only on Multiplication Operator :'*'", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }

                    }
                    count1 = 0;
                }
                else if (choice.Text == "Substraction ->  [ - ]")
                {
                    if (counterradio.Checked)
                    {
                        coutval = double.Parse(counter.Text);
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        for (l = 0; l < coutval; l++)
                        {
                            opl = first2 - second2;
                        }
                        res1.Text = "Result : " + opl * coutval;
                        res2.Text = "Time Applied : " + coutval + " times!";
                    }
                    else
                    {
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        oper1 = string.Format(oper.Text);

                        for (j = 0; j < oper1.Length; j++)
                        {

                            if (oper1[j] == '-')
                            {
                                count1++;
                                res = first2 - second2;
                                res1.Text = "The result :" + res * count1;
                                res2.Text = "Time applied :" + count1 + " times!";

                            }

                        }
                        if (oper.TextLength == 0)
                        {
                            MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (oper1.Length > count1)
                        {
                            MessageBox.Show("the operator field is contain some uncode charecter!\nNotice that calcilation will aplly only on Substraction Operator :'-'", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                    }
                    count1 = 0;
                }
                else if (choice.Text == "Division  ->  [ / ]")
                {
                    if (counterradio.Checked)
                    {
                        coutval = double.Parse(counter.Text);
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        for (l = 0; l < coutval; l++)
                        {
                            opl = first2 / second2;
                        }
                        res1.Text = "Result : " + opl * coutval;
                        res2.Text = "Time Applied : " + coutval + " times!";
                    }
                    else
                    {
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        oper1 = string.Format(oper.Text);

                        for (j = 0; j < oper1.Length; j++)
                        {

                            if (oper1[j] == '/')
                            {
                                count1++;
                                res = first2 / second2;
                                res1.Text = "The result :" + res * count1;
                                res2.Text = "Time applied :" + count1 + " times!";

                            }

                        }
                        if (oper.TextLength == 0)
                        {
                            MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (oper1.Length > count1)
                        {
                            MessageBox.Show("the operator field is contain some uncode charecter!\nNotice that calcilation will aplly only on Divisin Operator :'/'", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                    }
                    count1 = 0;
                }
                else if (choice.Text == "Modulo -> [ % ]")
                {
                    if (counterradio.Checked)
                    {
                        coutval = double.Parse(counter.Text);
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        for (l = 0; l < coutval; l++)
                        {
                            opl = first2 % second2;
                        }
                        res1.Text = "Result : " + opl * coutval;
                        res2.Text = "Time Applied : " + coutval + " times!";
                    }
                    else
                    {
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        oper1 = string.Format(oper.Text);

                        for (j = 0; j < oper1.Length; j++)
                        {

                            if (oper1[j] == '%')
                            {
                                count1++;
                                res = first2 % second2;
                                res1.Text = "The result :" + res * count1;
                                res2.Text = "Time applied :" + count1 + " times!";

                            }

                        }
                        if (oper.TextLength == 0)
                        {
                            MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (oper1.Length > count1)
                        {
                            MessageBox.Show("the operator field is contain some uncode charecter!\nNotice that calcilation will aplly only on Mod Operator :'%'", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                    }
                    count1 = 0;
                }
                else if (choice.Text == "Power - [ ^ ]")
                {
                    if (counterradio.Checked)
                    {
                        coutval = double.Parse(counter.Text);
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        for (l = 0; l < coutval; l++)
                        {
                            opl = Math.Pow(first2, second2);
                        }
                        res1.Text = "Result : " + opl * coutval;
                        res2.Text = "Time Applied : " + coutval + " times!";
                    }
                    else
                    {
                        first2 = double.Parse(first.Text);
                        second2 = double.Parse(second.Text);
                        oper1 = string.Format(oper.Text);

                        for (j = 0; j < oper1.Length; j++)
                        {

                            if (oper1[j] == '^')
                            {
                                count1++;
                                res = Math.Pow(first2, second2);
                                res1.Text = "The result :" + res * count1;
                                res2.Text = "Time applied :" + count1 + " times!";

                            }

                        }
                        if (oper.TextLength == 0)
                        {
                            MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (oper1.Length > count1)
                        {
                            MessageBox.Show("the operator field is contain some uncode charecter!\nNotice that calcilation will aplly only on Power Operator :'^'", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                    }
                    count1 = 0;
                }
                else if (choice.Text == "Factorial - [ ! ]")
                {
                    try
                    {
                        if (counterradio.Checked)
                        {
                            int som1 = int.Parse(first.Text);
                            coutval = double.Parse(counter.Text);
                            //  first2 = double.Parse(first.Text);
                            //  second2 = double.Parse(second.Text);
                            // for (l = 0; l < coutval; l++)
                            // {
                            opl = Fac(som1);
                            // }
                            res1.Text = "Result : " + opl * coutval;
                            res2.Text = "Time Applied : " + coutval + " times!";
                        }
                        else if (operradio.Checked)
                        {
                            int som = int.Parse(first.Text);
                            oper1 = oper.Text;
                            oper1 = string.Format(oper.Text);

                            for (j = 0; j < oper1.Length; j++)
                            {

                                if (oper1[j] == '!')
                                {
                                    count1++;
                                    res = Fac(som);
                                    res1.Text = "The result :" + res * count1;
                                    res2.Text = "Time applied :" + count1 + " times!";

                                }

                            }
                            if (oper.TextLength == 0)
                            {
                                MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (oper1.Length > count1)
                            {
                                MessageBox.Show("the operator field is contain some uncode charecter!\nNotice that calcilation will aplly only on Factorial Operator :'!'", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            }
                        }
                        count1 = 0;
                    }
                    catch (Exception)
                    {

                      MessageBox.Show("Value out of rang!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (choice.Text == "ALL OPERATIONS -> [ * ]")
                {

                    first2 = double.Parse(first.Text);
                    second2 = double.Parse(second.Text);
                    oper1 = string.Format(oper.Text);

                    for (j = 0; j < oper1.Length; j++)
                    {
                        if (oper1[j] == '+')
                        {
                            add_count++;
                            global_count++;
                            add = (first2 + second2);
                        }
                        else if (oper1[j] == '*')
                        {
                            mul_count++;
                            global_count++;
                            mul = (first2 * second2);
                        }
                        else if (oper1[j] == '-')
                        {
                            sub_count++;
                            global_count++;
                            sub = (first2 - second2);
                        }
                        else if (oper1[j] == '/')
                        {
                            div_count++;
                            global_count++;
                            div = (first2 / second2);
                        }
                        else if (oper1[j] == '%')
                        {
                            mod_count++;
                            global_count++;
                            mod = (first2 % second2);
                        }
                        else if (oper1[j] == '^')
                        {
                            pow_count++;
                            global_count++;
                            pow = Math.Pow(first2, second2);

                        }
                        else if (oper1[j] == '!')
                        {
                            int som = int.Parse(first.Text);
                            fac_count++;
                            global_count++;
                            fac = Fac(som);

                        }

                    }
                    // global_count = add_count + mul_count + sub_count + div_count + mod_count + fac_count;
                    if (oper.TextLength == 0)
                    {
                        MessageBox.Show("the operator field has been lefted blank!!\nPlease enter an operator to calcilate!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (oper1.Length > global_count)
                    {
                        MessageBox.Show("the operator field is contain some uncode charecters!\nNotice that calcilation will never apply on those Charecters..!!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }


                    res = add + mul + sub + div + mod + pow + fac;
                    res1.Text = "The result :" + (res *= global_count);
                    res2.Text = "Time applied :" + global_count + " times!";

                    global_count = new_global_count;
                    global_count = 0;
                }
                else
                {
                    MessageBox.Show("Please select operation!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                show.Visible = true;
            }
            catch (Exception)
            {
                if (!isNumber)
                {
                    MessageBox.Show("You have been entered some unicode charecters within FirstNumber.!\nPleae enter Numerique Value Only..!!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!isNumber2)
                {
                    MessageBox.Show("You have been entered some unicode charecters within SecondNumber.!\nPleae enter Numerique Value Only..!!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (first2.ToString().Length == 0)
                {
                    MessageBox.Show("First Number feild has been lefted blank ..!!\nPlease enter some value!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (second2 .ToString ().Length == 0)
                {
                    MessageBox.Show("Second Number feild has been lefted blank..!!\nPlease enter some value!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }


 //..the Detailes_Show....


        private void show_Click(object sender, EventArgs e)
        {            
           
            //  textBox1.Visible = true;
            groupBox2.Visible = true;
            sho.Visible = true;

            hide.Visible = true;

            if (choice.Text == "Addition -> [ + ]")
            {
                if (counterradio.Checked)
                {
                    sho.Items.Clear();

                    sho.Items.Add("sum of operation..\n");
                    for (l = 0; l < counter.Value; l++)
                    {
                        sho.Items.Add(first2);
                        sho.Items.Add("+");
                        sho.Items.Add(second2);
                        sho.Items.Add("--------------------");
                        sho.Items.Add("= " + opl + "\n");
                    }
                    sho.Items.Add("sum of operation's results..\n");
                    for (t = 0; t < counter.Value; t++)
                    {
                        sho.Items.Add(opl);
                        sho.Items.Add("+");
                    }
                    sho.Items.Add("------------\n");
                    sho.Items.Add("=" + opl * coutval);
                    sho.Items.Add("\nFinal result :" + opl * coutval);
                    //double forn = ( Form1.ActiveForm.Size.Height);

                }

                else if (operradio.Checked)
                {
                    sho.Items.Clear();

                    sho.Items.Add("sum of operation..\n");
                    for (j = 0; j < oper1.Length; j++)
                        if (oper1[j] == '+')
                            count1++;
                    for (m = 0; m < count1; m++)
                    {
                        sho.Items.Add(first2 + " + " + second2 + " = " + res);
                    }
                    sho.Items.Add("sum of operation's results..\n");

                    for (t = 0; t < count1; t++)
                    {
                        sho.Items.Add(res);
                        sho.Items.Add("+");

                    }
                    sho.Items.Add("------------\n");
                    sho.Items.Add("=" + res * count1);
                    sho.Items.Add("\nFinal result :" + res * count1);
                    sho.Items.Add("-----------------");
                    count1 = 0;

                }

            }
            else if (choice.Text == "Multiplication -> [ X ]")
            {
                if (counterradio.Checked)
                {
                    sho.Items.Clear();

                    sho.Items.Add("mul of operation..\n");
                    for (l = 0; l <= counter.Value; l++)
                    {
                        sho.Items.Add(first2);
                        sho.Items.Add("*");
                        sho.Items.Add(second2);
                        sho.Items.Add("--------------------");
                        sho.Items.Add("= " + opl + "\n");
                    }
                    sho.Items.Add("sum of operation's results..\n");
                    for (l = 0; l <= counter.Value; l++)
                    {
                        sho.Items.Add(opl);
                        sho.Items.Add("+");
                    }
                    sho.Items.Add("------------\n");
                    sho.Items.Add("=" + opl * coutval);
                    sho.Items.Add("\nFinal result :" + opl * coutval);


                    //double forn = ( Form1.ActiveForm.Size.Height);

                }

                else if (operradio.Checked)
                {
                    sho.Items.Clear();

                    sho.Items.Add("mul of operation..\n");
                    for (j = 0; j < oper1.Length; j++)
                        if (oper1[j] == '*')
                            count1++;
                    for (m = 0; m < count1; m++)
                    {
                        sho.Items.Add(first2 + " * " + second2 + " = " + res);
                    }
                    sho.Items.Add("sum of operation's results..\n");

                    for (t = 0; t < count1; t++)
                    {
                        sho.Items.Add(res);
                        sho.Items.Add("+");

                    }
                    sho.Items.Add("------------\n");
                    sho.Items.Add("=" + res * count1);
                    sho.Items.Add("\nFinal result :" + res * count1);
                    sho.Items.Add("--------------------");



                    count1 = 0;
                }
                }
                else if (choice.Text == "Substraction ->  [ - ]")
                {
                    if (counterradio.Checked)
                    {
                        sho.Items.Clear();

                        sho.Items.Add("sub of operation..\n");
                     
                        for (l = 0; l <= counter.Value; l++)
                        {
                            sho.Items.Add(first2);
                            sho.Items.Add("-");
                            sho.Items.Add(second2);
                            sho.Items.Add("--------------------");
                            sho.Items.Add("= " + opl + "\n");
                        }
                        sho.Items.Add("sum of operation's results..\n");
                        for (l = 0; l <= counter.Value; l++)
                        {
                            sho.Items.Add(opl);
                            sho.Items.Add("+");
                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + opl * coutval);
                        sho.Items.Add("\nFinal result :" + opl * coutval);


                        //double forn = ( Form1.ActiveForm.Size.Height);

                    }

                    else if (operradio.Checked)
                    {
                        sho.Items.Clear();

                        sho.Items.Add("sub of operation..\n");
                        for (j = 0; j < oper1.Length; j++)
                            if (oper1[j] == '-')
                                count1++;
                        for (m = 0; m < count1; m++)
                        {
                            sho.Items.Add(first2 + " - " + second2 + " = " + res);
                        }
                        sho.Items.Add("sum of operation's results..\n");

                        for (t = 0; t < count1; t++)
                        {
                            sho.Items.Add(res);
                            sho.Items.Add("+");

                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + res * count1);
                        sho.Items.Add("\nFinal result :" + res * count1);
                        sho.Items.Add("-------------------");



                        count1 = 0;
                      
                    }
                }
                else if (choice.Text == "Division  ->  [ / ]")
                {
                    if (counterradio.Checked)
                    {
                        sho.Items.Clear();

                        sho.Items.Add("div of operation..\n");
                        for (l = 0; l <= counter.Value; l++)
                        {
                            sho.Items.Add(first2);
                            sho.Items.Add("/");
                            sho.Items.Add(second2);
                            sho.Items.Add("--------------------");
                            sho.Items.Add("= " + opl + "\n");
                        }
                        sho.Items.Add("sum of operation's results..\n");
                        for (l = 0; l <= counter.Value; l++)
                        {
                            sho.Items.Add(opl);
                            sho.Items.Add("+");
                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + opl * coutval);
                        sho.Items.Add("\nFinal result :" + opl * coutval);


                        //double forn = ( Form1.ActiveForm.Size.Height);

                    }

                    else if (operradio.Checked)
                    {
                        sho.Items.Clear();

                        sho.Items.Add("div of operation..\n");
                        for (j = 0; j < oper1.Length; j++)
                            if (oper1[j] == '/')
                                count1++;
                        for (m = 0; m < count1; m++)
                        {
                            sho.Items.Add(first2 + " / " + second2 + " = " + res);
                        }
                        sho.Items.Add("sum of operation's results..\n");

                        for (t = 0; t < count1; t++)
                        {
                            sho.Items.Add(res);
                            sho.Items.Add("+");

                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + res * count1);
                        sho.Items.Add("\nFinal result :" + res * count1);
                        sho.Items.Add("--------------------");



                        count1 = 0;
                      
                    }
                }
                else if (choice.Text == "Modulo -> [ % ]")
                {
                     if (counterradio.Checked)
                {
                    sho.Items.Clear();

                    sho.Items .Add("mod of operation..\n");
                    for (l = 0; l <= counter.Value; l++)
                    {
                        sho.Items.Add(first2);
                        sho.Items.Add("%");
                        sho.Items.Add(second2);
                        sho.Items.Add("--------------------");
                        sho.Items.Add("= " + opl + "\n");
                    }
                    sho.Items.Add("sum of operation's results..\n");
                    for (l = 0; l <= counter.Value; l++)
                    {
                        sho.Items.Add(opl);
                        sho.Items.Add("+");
                    }
                    sho.Items.Add("------------\n");
                    sho.Items.Add("=" + opl * coutval);
                    sho.Items.Add("\nFinal result :" + opl * coutval);

                  
                  //double forn = ( Form1.ActiveForm.Size.Height);

                }
                    
                else if(operradio .Checked )
                {
                    sho.Items.Clear();

                        sho.Items.Add("mod of operation..\n");
                        for (j = 0; j < oper1.Length; j++)
                        {
                            if (oper1[j] == '%')
                                count1++;
                            for (m = 0; m < count1; m++)
                             {
                            sho.Items.Add(first2 + " % " + second2 + " = " + res);
                            }
                        }
                        sho.Items.Add("sum of operation's results..\n");

                        for (t = 0; t < count1; t++)
                        {
                            sho.Items.Add(res);
                            sho.Items.Add("+");

                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + res * count1);
                        sho.Items.Add("\nFinal result :" + res * count1);
                        sho.Items.Add("-------------------");                       

                        count1 = 0;
                }
                                                              
                }
                else if (choice.Text == "Power - [ ^ ]")
                {
                    if (counterradio.Checked)
                    {
                        sho.Items.Clear();
                        sho.Items.Add("pow of operation..\n");
                        for (l = 0; l <= counter.Value; l++)
                        {
                            sho.Items.Add(first2);
                            sho.Items.Add("^");
                            sho.Items.Add(second2);
                            sho.Items.Add("----------------------");
                            sho.Items.Add("= " + opl + "\n");
                        }
                        sho.Items.Add("sum of operation's results..\n");
                        for (l = 0; l <= counter.Value; l++)
                        {
                            sho.Items.Add(opl);
                            sho.Items.Add("+");
                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + opl * coutval);
                        sho.Items.Add("\nFinal result :" + opl * coutval);
                    }
                         else if(operradio .Checked )
                {
                    sho.Items.Clear();

                        sho.Items.Add("pow of operation..\n");
                        for (j = 0; j < oper1.Length; j++)
                            if (oper1[j] == '^')
                                count1++;
                        for (m = 0; m < count1; m++)
                        {
                            sho.Items.Add(first2 + " ^ " + second2 + " = " + res);
                        }
                        sho.Items.Add("sum of operation's results..\n");

                        for (t = 0; t < count1; t++)
                        {
                            sho.Items.Add(res);
                            sho.Items.Add("+");

                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + res * count1);
                        sho.Items.Add("\nFinal result :" + res * count1);
                        sho.Items.Add("-----------------------");

                        

                        count1 = 0;
                
                                                              
                }}
                else if (choice.Text == "Factorial - [ ! ]")
                {
                    if (counterradio.Checked)
                    {
                        sho.Items.Clear();
                        sho.Items.Add("factorial of operation..\n");
                        for (l = 0; l <= counter.Value; l++)
                        {
                            int som1 = int.Parse(first.Text);
                            sho.Items.Add(som1);
                            sho.Items.Add("!");
                            sho.Items.Add("--------------");
                            sho.Items.Add("= " + opl + "\n");
                        }
                        sho.Items.Add("sum of operation's results..\n");
                        for (l = 0; l <= counter.Value; l++)
                        {
                            sho.Items.Add(opl);
                            sho.Items.Add("+");
                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + opl * coutval);
                        sho.Items.Add("\nFinal result :" + opl * coutval);
                    }
                    else if (operradio.Checked)
                    {
                        sho.Items.Clear();

                        sho.Items.Add("Factorial of operation..\n");
                        for (j = 0; j < oper1.Length; j++)
                            if (oper1[j] == '!')
                                count1++;
                        for (m = 0; m < count1; m++)
                        {
                            int som = int.Parse(first.Text);
                            sho.Items.Add(som +" !"+ "  = " + res);
                        }
                        sho.Items.Add("sum of operation's results..\n");

                        for (t = 0; t < count1; t++)
                        {
                            sho.Items.Add(res);
                            sho.Items.Add("+");

                        }
                        sho.Items.Add("------------\n");
                        sho.Items.Add("=" + res * count1);
                        sho.Items.Add("\nFinal result :" + res * count1);
                        sho.Items.Add("-----------------------");



                        count1 = 0;
                    }
                }

                else if (choice.Text == "ALL OPERATIONS -> [ * ]")
                {
                           sho.Items.Clear();
                    //sho.Items.RemoveAt(4);
                           for (j = 0; j < oper1.Length; j++)
                            if (oper1[j] == '+')
                           {
                                add_count++;
                                sho.Items.Add("sum of operation..\n");
                                som1 = int.Parse(first.Text);
                                for (m = 0; m < add_count; m++)
                                    sho.Items.Add(first2 + " + " + second2 + " = " + add);
                                add_count = 0;
                                // for (j = 0; j < oper1.Length; j++)
                            }
                            else if (oper1[j] == '*')
                            {
                                mul_count++;
                                sho.Items.Add("mul of operation..\n");
                                for (m = 0; m < mul_count; m++)
                                    sho.Items.Add(first2 + " * " + second2 + " = " + mul);
                                mul_count = 0;
                                //  for (j = 0; j < oper1.Length; j++)
                            } 
                            else if (oper1[j] == '-')
                            {
                                sub_count++;
                                sho.Items.Add("sub of operation..\n");
                                for (m = 0; m < sub_count; m++)
                                    sho.Items.Add(first2 + " - " + second2 + " = " + sub);
                                sub_count = 0;

                                //  for (j = 0; j < oper1.Length; j++)
                            }
                            else if (oper1[j] == '/')
                            {
                                div_count++;
                                sho.Items.Add("div of operation..\n");
                                for (m = 0; m < div_count; m++)

                                    sho.Items.Add(first2 + " / " + second2 + " = " + div);

                                div_count = 0;

                                // for (j = 0; j < oper1.Length; j++)
                            }
                            else if (oper1[j] == '%')
                            {
                                mod_count++;
                                sho.Items.Add("mod of operation..\n");
                                for (m = 0; m < mod_count; m++)

                                    sho.Items.Add(first2 + " % " + second2 + " = " + mod);

                                mod_count = 0;
                                // for (j = 0; j < oper1.Length; j++)
                            }
                            else if (oper1[j] == '^')
                            {
                                pow_count++;
                                sho.Items.Add("power of operation..\n");
                                for (m = 0; m < pow_count; m++)

                                    sho.Items.Add(first2 + " ^ " + second2 + " = " + pow);

                                pow_count = 0;

                                //for (j = 0; j < oper1.Length; j++)
                            }
                            else if (oper1[j] == '!')
                            {
                                fac_count++;
                                sho.Items.Add("Factorial of operation..\n");
                                som1 = int.Parse(first.Text);
                                for (m = 0; m < fac_count; m++)
                                    sho.Items.Add(som1 + " !" + "  = " + fac);


                                fac_count = 0;
                            }
                            else
                            {
                                sho.Items.Add("Unkoun charecter!!");
                            }   
               

             sho.Items.Add("sum of operation's results..\n");
           
            for (t = 0; t < oper1.Length ; t++) 
            {
                if (oper1[t] == '+')
                {
                    sho.Items.Add(add );
                    sho.Items.Add("+");
                }
                else if (oper1[t] == '*')
                {
                    sho.Items.Add(mul );
                    sho.Items.Add("+");
                }
                else if (oper1[t] == '-')
                {
                    sho.Items.Add(sub );
                    sho.Items.Add("+");
                }
                else if (oper1[t] == '/')
                {
                    sho.Items.Add(div );
                    sho.Items.Add("+");
                }
                else if (oper1[t] == '%')
                {
                    sho.Items.Add(mod );
                    sho.Items.Add("+");
                }
                else if (oper1[t] == '^')
                {
                    sho.Items.Add(pow );
                    sho.Items.Add("+");
                }
                else if (oper1[t] == '!')
                {
                    sho.Items.Add(fac );
                    sho.Items.Add("+");
                }

            }
            sho.Items.Add("------------\n");
            sho.Items.Add("=" + res  );
            sho.Items.Add("\nFinal result :" + res );
            sho.Items.Add("-----------------");

            global_count = 0;
                }
                 
            else
            {
                MessageBox.Show("Invalide Inpute!", "Super_Calcilator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            sho.Visible = false;
            groupBox2.Visible = false;

            show.Visible = true;
        }

        private void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choice.Text == "Factorial - [ ! ]")
            {
                second.Enabled = false;
            }
            else
            {
                second.Enabled = true;
            }
            if (choice.Text == "ALL OPERATIONS -> [ * ]")
            {
                counterradio.Visible  = false;
            }
            else
            {
                counterradio.Visible = true;
            }
             

        }

        private void counterradio_CheckedChanged(object sender, EventArgs e)
        { 
            counter.Visible = true;
            label7.Visible = true;
            oper.Enabled = false;
            counter.Enabled = true;
            call.Visible = true;
            groupBox3.Visible = true;
             
        }

        private void operradio_CheckedChanged(object sender, EventArgs e)
        {
            oper.Visible = true;
            label9.Visible = true;
            counter.Enabled = false;
            oper.Enabled = true;
            call.Visible = true;
            groupBox3.Visible = true;
            if (choice.Text == "Multiplication -> [ X ]")
            {
                label8.Text = "- like -> [***************]";
            }
            else if (choice.Text == "Addition -> [ + ]")
            {
                label8.Text = "- like -> [++++++++++++++]";
            }
            else if (choice.Text == "Substraction ->  [ - ]")
            {
                label8.Text = "- like -> [--------------]";
            }
            else if (choice.Text == "Division  ->  [ / ]")
            { 
                label8.Text = "- like -> [/////////////]";
            }
            else if (choice.Text == "Modulo -> [ % ]")
            {
                label8.Text = "- like -> [%%%%%%%%%%%%%]";
            }
            else if (choice.Text == "Factorial - [ ! ]")
            {
                label8.Text = "- like -> [!!!!!!!!!!!!!!]";
            }
            else if (choice.Text == "Power - [ ^ ]")
            {
                label8 .Text = "- like -> [^^^^^^^^^^^^^^]";
            }
            else if (choice.Text == "ALL OPERATIONS -> [ * ]")
            {
                label8.Text = "- like -> [****++++----////%%%%%^^^^^!!!!!!!]";
            }
            else
            {
                label8.Text = "";
            }
           
        }

        private void oper_TextChanged(object sender, EventArgs e)
        {
            coun++;
        }

        private void counter_ValueChanged(object sender, EventArgs e)
        {
            
            radiocoun++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            //textBox1.Visible = true;
            //int pol = 0;
            ////for (pol = 0; pol < 50; pol++)

            //    textBox1.Text += "this is not just about what you see ..but what you can't see" ;
            //    textBox1.Text += null;

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            {

            }
        }

        private void rEDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (oper.CanUndo == true)
                {
                    oper.Undo();
                    oper.ClearUndo();

                }
             
                if(first .CanUndo ==true)
                {
                    first.Undo();
                    first.ClearUndo();
               if(second .CanUndo ==true)
                {
                    second.Undo();
                    second.ClearUndo();
                }
               
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oper.SelectedText != "")
            {
                oper.Cut();

            }
            string somtext;
            if (oper.SelectedText != "")
            {
                somtext = oper.SelectedText;
                MessageBox.Show(somtext);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oper.SelectionLength > 0 )
            {
                oper.Copy();
                 
            }
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

       

        private void veiwImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string chosen_file = "";
            //openFD.InitialDirectory = "C:";
            //openFD.FileName = "";
            //openFD.Filter = "JEPG Images|*.jpg|GIF Images|*.jif|BITMAP Images|*.bmp|PNG Images|.png|ALL FILES|*.*";
        
            //openFD.ShowDialog();
            //try
            //{
            //    chosen_file = openFD.FileName;
                 
            //}
            //catch (Exception )
            //{
            //     MessageBox.Show("Operation Canceled!");
            //}
        }

        private void oPENToolStripMenuItem_Click(object OpenUp, EventArgs mouse)
        {
            choice.Text = "Multiplication -> [ X ]";

               

        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
        private void first_MouseLeave(object sender, EventArgs e)
        {
            //if (first2 == 0)
            //{
            //    label10.Text = "you can't leave this field blank!";
            //    first.Focus();
            //}
            //else if(first2 !=0)
            //{
            //    label10.Text = "";
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(strkey);

                if (reg != null)
                {
                    first.Text = ((string)reg.GetValue("first")); 
                    second.Text = ((string)reg.GetValue("second"));
                    choice.Text = ((string)reg.GetValue("choice"));
                    oper.Text = ((string)reg.GetValue("oper"));
                    //oper.Visible = ((bool)reg.GetValue("operb"));
                    //counter.Value = ((decimal )reg.GetValue("counter"));
                  //  counter.Visible = ((bool )reg.GetValue("counterb"));
                   // counterradio.Visible = ((bool)reg.GetValue("counr"));
                  //  operradio.Visible = ((bool)reg.GetValue("operr"));
                  //  call.Visible = ((bool)reg.GetValue("call"));
                  //  res1.Visible = ((bool)reg.GetValue("res1b"));
                  //  res2.Visible = ((bool)reg.GetValue("res2b"));
                    res1.Text = ((string)reg.GetValue("res1"));
                    res2.Text = ((string)reg.GetValue("res2"));
                  //  show.Visible = ((bool)reg.GetValue("show"));
                  //  hide.Visible = ((bool)reg.GetValue("hide"));
                  //  sho.Visible = ((bool)reg.GetValue("sho"));
                    sho.Text = ((string)reg.GetValue("shot"));

                    reg.Close();
                }
            }catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void first_Leave(object sender, EventArgs e)
        { 
        }

        private void second_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///new loadF().ShowDialog(this);
            new About_us().ShowDialog(this);
            
        }
        
        private void clearFeildsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            first.Clear();
            second.Clear();
            oper.Clear();
            sho.Items.Clear();

        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            choice .Text ="Addition -> [ + ]";
                
//
//
//
//
//
//
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            choice.Text = "Substraction ->  [ - ]";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            choice.Text = "Division  ->  [ / ]";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            choice.Text = "Modulo -> [ % ]";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            choice.Text = "Factorial - [ ! ]";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
            choice.Text = "Power - [ ^ ]";
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            choice.Text = "ALL OPERATIONS -> [ * ]";
        }

        private void helpOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Mohamed-94/";
            System.Diagnostics.Process.Start(url);
        }

        private void sAVEALLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistryKey reg1 = Registry.CurrentUser.OpenSubKey(strkey, true);
            if (reg1 == null)
                reg1 = Registry.CurrentUser.CreateSubKey(strkey);

            reg1.SetValue("first", first.Text);
            reg1.SetValue("second", second.Text);
            reg1.SetValue("choice", choice.Text);
            reg1.SetValue("oper", oper.Text);
            reg1.SetValue("operb", oper.Visible);
            reg1.SetValue("counter", counter.Value);
            reg1.SetValue("counterb", counter.Visible);
            reg1.SetValue("counr", counterradio.Visible);
            reg1.SetValue("operr", operradio.Visible);
            reg1.SetValue("res1", res1.Text);
            reg1.SetValue("res1b", res1.Visible);
            reg1.SetValue("res2", res2.Text);
            reg1.SetValue("res2b", res2.Visible);
            reg1.SetValue("call", call.Visible);
            reg1.SetValue("show", show.Visible);
            reg1.SetValue("hide", hide.Visible);
            reg1.SetValue("shot", sho.Text);
            reg1.SetValue("sho", sho.Visible);


            reg1.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void superCalcilatorCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void superCalculatorCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Mohamed-94/Super-Calcilator_Cpp_CommandLine";
            System.Diagnostics.Process.Start(url);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
