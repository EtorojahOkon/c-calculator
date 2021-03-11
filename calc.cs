using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace CalculatorApp
{
    class Calculator:Form
    {
        //properties
        public TextBox main_disp;
        public TextBox date_disp;
        public Button btn0;
        public Button btn1;
        public Button btn2;
        public Button btn3;
        public Button btn4;
        public Button btn5;
        public Button btn6;
        public Button btn7;
        public Button btn8;
        public Button btn9;
        public Button btn_dec;
        public Button equal;
        public Button plus;
        public Button minus;
        public Button times;
        public Button div;
        public Button clr;
        public Button per_cent;
        public Button pow;
        public Button pie;
        public Button pow_neg;
        public Button sqrt;
        public Button times_pow;
        public Button del;
        public Button cos;
        public Button tan;
        public Button log;
        public Button sin;
        public Button usage;
        public Button right;
        public Button left;
        public Button off;
        public Button coma;
        
        Calculator()
        {
            //this.Icon = new Icon("calc.ico");
            this.SuspendLayout();
            this.BackColor = Color.Gray;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(430,410);
            
            
            //Creating components
            main_disp = new TextBox();
            main_disp.Text = "0";
            main_disp.Location = new System.Drawing.Point(10,50);
            main_disp.ReadOnly = true;
            main_disp.Font = new Font("Segoe UI", 30);
            main_disp.MinimumSize = new Size(397, 60);
            main_disp.BorderStyle = BorderStyle.FixedSingle;
            main_disp.TextAlign = HorizontalAlignment.Right;
            main_disp.ShortcutsEnabled = false;
            
            date_disp = new TextBox();
            date_disp.Location =new System.Drawing.Point(305,20);
            date_disp.ReadOnly = true;
            date_disp.Text = GetTime();
            date_disp.ShortcutsEnabled = false;
            date_disp.BorderStyle = BorderStyle.FixedSingle;
            
            right =  new Button();
            right.Location = new System.Drawing.Point(250,140);
            right.Text = "→";
            right.AutoSize = true;
            right.BackColor = Color.White;
            

            left =  new Button();
            left.Location = new System.Drawing.Point(90,140);
            left.Text = "←";
            left.AutoSize = true;
            left.BackColor = Color.White;
            
            btn0 =  new Button();
            btn0.Location = new System.Drawing.Point(10,320);
            btn0.Text = "0";
            btn0.AutoSize = true;
            btn0.BackColor = Color.White;

            btn1 =  new Button();
            btn1.Location =new System.Drawing.Point(10,290);
            btn1.Text = "1";
            btn1.AutoSize = true;
            btn1.BackColor = Color.White;

            btn2 =  new Button();
            btn2.Location =new System.Drawing.Point(90,290);
            btn2.Text = "2";
            btn2.AutoSize = true;
            btn2.BackColor = Color.White;

            btn3 =  new Button();
            btn3.Location =new System.Drawing.Point(170,290);
            btn3.Text = "3";
            btn3.AutoSize = true;
            btn3.BackColor = Color.White;

            btn4 =  new Button();
            btn4.Location =new System.Drawing.Point(10,260);
            btn4.Text = "4";
            btn4.AutoSize = true;
            btn4.BackColor = Color.White;

            btn5 =  new Button();
            btn5.Location =new System.Drawing.Point(90,260);
            btn5.Text = "5";
            btn5.AutoSize = true;
            btn5.BackColor = Color.White;

            btn6 =  new Button();
            btn6.Location =new System.Drawing.Point(170,260);
            btn6.Text = "6";
            btn6.AutoSize = true;
            btn6.BackColor = Color.White;

            btn7 =  new Button();
            btn7.Location =new System.Drawing.Point(10,230);
            btn7.Text = "7";
            btn7.AutoSize = true;
            btn7.BackColor = Color.White;

            btn8 =  new Button();
            btn8.Location =new System.Drawing.Point(90,230);
            btn8.Text = "8";
            btn8.AutoSize = true;
            btn8.BackColor = Color.White;

            btn9 =  new Button();
            btn9.Location =new System.Drawing.Point(170,230);
            btn9.Text = "9";
            btn9.AutoSize = true;
            btn9.BackColor = Color.White;

            equal =  new Button();
            equal.Location =new System.Drawing.Point(330,320);
            equal.Text = "=";
            equal.AutoSize = true;
            equal.BackColor = Color.Blue;
            equal.ForeColor = Color.White;

            clr =  new Button();
            clr.Location =new System.Drawing.Point(330,230);
            clr.Text = "AC";
            clr.AutoSize = true;
            clr.BackColor = Color.Red;
            clr.ForeColor = Color.White;
                        
            plus =  new Button();
            plus.Location =new System.Drawing.Point(330,290);
            plus.Text = "+";
            plus.AutoSize = true;
            plus.BackColor = Color.White;

            btn_dec =  new Button();
            btn_dec.Location =new System.Drawing.Point(90,320);
            btn_dec.Text = ".";
            btn_dec.AutoSize = true;
            btn_dec.BackColor = Color.White;

            minus =  new Button();
            minus.Location =new System.Drawing.Point(250,290);
            minus.Text = "-";
            minus.AutoSize = true;
            minus.BackColor = Color.White;

            times =  new Button();
            times.Location =new System.Drawing.Point(330,260);
            times.Text = "x";
            times.AutoSize = true;
            times.BackColor = Color.White;

            div =  new Button();
            div.Location =new System.Drawing.Point(250,260);
            div.Text = "/";
            div.AutoSize = true;
            div.BackColor = Color.White;

            per_cent =  new Button();
            per_cent.Location =new System.Drawing.Point(250,200);
            per_cent.Text = "%";
            per_cent.AutoSize = true;
            per_cent.BackColor = Color.White;

            pow =  new Button();
            pow.Location =new System.Drawing.Point(10,170);
            pow.Text = "^";
            pow.AutoSize = true;
            pow.BackColor = Color.White;

            pie =  new Button();
            pie.Location =new System.Drawing.Point(250,320);
            pie.Text = "π";
            pie.AutoSize = true;
            pie.BackColor = Color.White;

            pow_neg =  new Button();
            pow_neg.Location =new System.Drawing.Point(10,140);
            pow_neg.Text = "^-1";
            pow_neg.AutoSize = true;
            pow_neg.BackColor = Color.White;

            off =  new Button();
            off.Location =new System.Drawing.Point(330,140);
            off.Text = "OFF";
            off.AutoSize = true;
            off.BackColor = Color.Red;
            off.ForeColor = Color.White;

            sqrt =  new Button();
            sqrt.Location =new System.Drawing.Point(90,200);
            sqrt.Text = "√";
            sqrt.AutoSize = true;
            sqrt.BackColor = Color.White;

            times_pow =  new Button();
            times_pow.Location =new System.Drawing.Point(170,320);
            times_pow.Text = "^2";
            times_pow.AutoSize = true;
            times_pow.BackColor = Color.White;

            del =  new Button();
            del.Location =new System.Drawing.Point(250,230);
            del.Text = "DEL";
            del.AutoSize = true;
            del.BackColor = Color.Orange;
            del.ForeColor = Color.White;
            
            cos =  new Button();
            cos.Location =new System.Drawing.Point(170,200);
            cos.Text = "cos";
            cos.AutoSize = true;
            cos.BackColor = Color.White;

            tan =  new Button();
            tan.Location =new System.Drawing.Point(330,200);
            tan.Text = "tan";
            tan.AutoSize = true;
            tan.BackColor = Color.White;

            log =  new Button();
            log.Location =new System.Drawing.Point(330,170);
            log.Text = "log";
            log.AutoSize = true;
            log.BackColor = Color.White;

            sin =  new Button();
            sin.Location =new System.Drawing.Point(10,200);
            sin.Text = "sin";
            sin.AutoSize = true;
            sin.BackColor = Color.White;

            usage =  new Button();
            usage.Location =new System.Drawing.Point(10,20);
            usage.Text = "Usage";
            usage.AutoSize = true;
            usage.BackColor = Color.White;

            coma =  new Button();
            coma.Location =new System.Drawing.Point(170,170);
            coma.Text = ",";
            coma.AutoSize = true;
            coma.BackColor = Color.White;
                        
            //handlers
            usage.Click += new System.EventHandler(Manual);
            if (main_disp.Text.ToString() == "")
            {
                main_disp.Text = "Pls turn on!";
            }
            else
            {
                del.Click += new System.EventHandler(Delete);
                clr.Click += new System.EventHandler(Clear);
                off.Click += new System.EventHandler(TurnOff);
                equal.Click += new System.EventHandler(Equals);
                btn0.Click += (sender, e) => { Append("0"); };
                btn1.Click += (sender, e) => { Append("1"); };
                btn2.Click += (sender, e) => { Append("2"); };
                btn3.Click += (sender, e) => { Append("3"); };
                btn4.Click += (sender, e) => { Append("4"); };
                btn5.Click += (sender, e) => { Append("5"); };
                btn6.Click += (sender, e) => {Append("6");};
                btn7.Click += (sender, e) => {Append("7");};
                btn8.Click += (sender, e) => {Append("8");};
                btn9.Click += (sender, e) => {Append("9");};
                btn_dec.Click += (sender, e) => {Append(".");};
                plus.Click += (sender, e) => {Append("+");};
                minus.Click += (sender, e) => {Append("-");};
                times.Click += (sender, e) => {Append("*");};
                div.Click += (sender, e) => {Append("/");};
                pow.Click += (sender, e) => {Append("^");};
                pie.Click += (sender, e) => {Append(Math.PI.ToString());};
                pow_neg.Click += (sender, e) => {Append("^-1");};
                coma.Click += (sender, e) => {Append(",");};
                times_pow.Click += (sender, e) => {Append("^2");};
                per_cent.Click += (sender, e) => {Solve("percent");};
                sqrt.Click += (sender, e) => {Solve("sqrt");};
                cos.Click += (sender, e) => {Solve("cos");};
                tan.Click += (sender, e) => {Solve("tan");};
                log.Click += (sender, e) => {Solve("log");};
                sin.Click += (sender, e) => {Solve("sin");};
                left.Click += (sender, e) => {MoveCursor("left");};
                right.Click += (sender, e) => {MoveCursor("right");};
            }

            //add components
            this.Controls.Add(right);
            this.Controls.Add(left);
            this.Controls.Add(date_disp);
            this.Controls.Add(usage);
            this.Controls.Add(plus);
            this.Controls.Add(clr);
            this.Controls.Add(main_disp);
            this.Controls.Add(equal);
            this.Controls.Add(btn0);
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btn7);
            this.Controls.Add(btn8);
            this.Controls.Add(btn9);
            this.Controls.Add(btn_dec);
            this.Controls.Add(minus);
            this.Controls.Add(times);
            this.Controls.Add(div);
            this.Controls.Add(per_cent);
            this.Controls.Add(pow);
            this.Controls.Add(pie);
            this.Controls.Add(pow_neg);
            this.Controls.Add(sqrt);
            this.Controls.Add(times_pow);
            this.Controls.Add(del);
            this.Controls.Add(cos);
            this.Controls.Add(tan);
            this.Controls.Add(log);
            this.Controls.Add(sin);
            this.Controls.Add(off);
            this.Controls.Add(coma);

            //Form title
            this.Text = "Calculator App";
            this.ResumeLayout(false);
        }

        //other functions
        private object EvaluateExpression(string eqn)
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(eqn, string.Empty);
            return result;
        }

        public void Append(string t)
        {
            main_disp.Text += t;
        }

        public string GetTime()
        {
            Console.WriteLine("Application opened at " + DateTime.Now.ToShortTimeString());
            return DateTime.Now.ToShortTimeString();
        }
        
        public void MoveCursor(string direction)
        {
            Console.WriteLine("Cursor moved " + direction);
        }

        public void  Solve(string trig)
        {
            double in_ex = Convert.ToDouble(main_disp.Text);
            double in_exp = in_ex * (Math.PI/180);
            switch (trig)
            {
                case "percent":
                    main_disp.Text = (in_ex/100).ToString();
                    break;
                case "sqrt":
                    main_disp.Text = Math.Sqrt(in_ex).ToString();
                    break;
                case "cos":
                    main_disp.Text = Math.Cos(in_exp).ToString();
                    break;
                case "tan":
                    main_disp.Text = Math.Tan(in_exp).ToString();
                    break;
                case "log":
                    main_disp.Text = Math.Log10(in_exp).ToString();
                    break;        

                default:
                    main_disp.Text = Math.Sin(in_exp).ToString();
                    break;
            }
            Console.WriteLine(trig + " " + in_ex.ToString() + " => " + main_disp.Text);
        }

        public void Delete(Object Sender, EventArgs e) 
        {
            int str_len = Convert.ToInt32(main_disp.Text.Length) - 1;
            if (str_len == 0 ||  main_disp.Text.Length == 0)
            {
                main_disp.Text = "0";
            }
            else
            {
                main_disp.Text = main_disp.Text.ToString().Substring(0, str_len);
            }
            Console.WriteLine("Deleted value from input field!");
        }

        public void Manual(Object Sender,EventArgs e)
        {
            string txt = "For any of the following[sin,cos,tan,log,%,sqrt], simply click the number button and the appropriate function button \n Eg press 16, then sqrt button to find sqrt of 16.\n\n For quadratic equations simply input in this format a,b,c(where a and b are coefficients of x^2 and x respectively and c is a constant) and press the equals sign";
            MessageBox.Show(txt);
            Console.WriteLine("You opened calculator manual!");
        }

        public void Equals(Object Sender, EventArgs e)
        {
            string str = main_disp.Text.Trim().ToString();
            if (main_disp.Text.Trim().Contains("^") == true)
            {
                char sep = '^';
                string[] txt_power = str.Split(sep);
                int sub_txt1 = Convert.ToInt32(txt_power[0]); 
                int sub_txt2 = Convert.ToInt32(txt_power[1]);
                string fval = Math.Pow(sub_txt1, sub_txt2).ToString();
                main_disp.Text = fval; 
                Console.WriteLine("Equation: " + str + " = " + fval);
            }
            else if (main_disp.Text.Trim().Contains(",") == true)
            {
                char deli = ',';
                string[] coeff = str.Split(deli);
                int coeff1 = Convert.ToInt32(coeff[0]);
                int coeff2 = Convert.ToInt32(coeff[1]);
                int coeff3 = Convert.ToInt32(coeff[2]);
                string res1 = ((-coeff2 + Math.Sqrt((coeff2*coeff2) - (4*coeff1*coeff3)))/(2*coeff1)).ToString();
                string res2 = ((-coeff2 - Math.Sqrt((coeff2*coeff2) - (4*coeff1*coeff3)))/(2*coeff1)).ToString();
                if (res1 == "NaN" && res2 == "NaN")
                {
                    main_disp.Text = "Maths error!";
                    Console.WriteLine("Quadratic equation: "+ coeff1 + "x^2 + " + coeff2 + "x + " + coeff3 + " = 0  |  Result => Maths error!");
                }
                else
                {
                    main_disp.Text = "x = " + res1 + " or x = " + res2;
                    Console.WriteLine("Quadratic equation: "+ coeff1 + "x^2 + " + coeff2 + "x + " + coeff3 + " = 0  |  Result => x =" + res1 + "or x = " + res2);
                }
            }
            else
            {
                try
                {
                    string result = Convert.ToString(EvaluateExpression(main_disp.Text.Trim()));
                    if (result == "NaN")
                    {
                        main_disp.Text = "Maths error!";
                        Console.WriteLine("Equation: " + str + " = Maths error!");
                    }
                    else
                    {
                        main_disp.Text = result;
                        Console.WriteLine("Equation: " + str + " = " + result);
                    }
                }
                catch (Exception ex)
                {
                    main_disp.Text = "Maths error!";
                    Console.WriteLine("Equation: " + str + " = Maths error!");
                }
            }
            
        }

        public void Clear(Object Sender,EventArgs e)
        {
            if (main_disp.Text == "")
            {
                main_disp.Text = "0";
                Console.WriteLine("You turned on calculator!");
                clr.Text = "AC";
            }
            else
            {
                main_disp.Text = "0";
                Console.WriteLine("You cleared input field!");
                
            }
        }

        public void TurnOff(Object Sender,EventArgs e)
        {
            main_disp.Text = "";
            Console.WriteLine("You turned off calculator!");
            clr.Text = "ON";
        }

        //Entry point
        public static void Main()
        {
            
            Application.Run(new Calculator());
            
        }
    }
    
}
