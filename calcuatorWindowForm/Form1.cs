using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace calcuatorWindowForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Declare variables and set to empty.

        string operationStr = "0";
        double answer = 0;
        List<string> operationList = new List<string> { "+", "–", "*", "/" };
        char dot = '·';

        int idxOperation = -1;
        string sliceStr1 = "";
        string sliceStr2 = "";
        bool haveDot1 = false;
        bool haveDot2 = false;

        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "–":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        public bool CheckLastIsOperation()
        {

            int index = operationStr.Length - 1;
            if (index > -1)
            {
               
                char s = operationStr[index];
                bool v = operationList.Contains(char.ToString(s));
                if (v)
               {                 
                    return true;
                }

            }
            return false;
        }

        public void LastIsNotNb()
        {
            if (CheckLastIsOperation())
            {
                operationStr += " ";
            }
        }

        public bool FirstIsZero(string str)
        {
            bool is0 = str[0].ToString() == "0";
            return is0;
        }

        public void ChecklastIndex(string operation)
        {
            Console.WriteLine($"{operation}  ChecklastIndex");
            int index = operationStr.Length - 1;
            char s = operationStr[index];

            bool v = operationList.Contains(char.ToString(s));
            if (v)
            {
                Console.WriteLine($"{operationStr} operationList.Contains{operation}");
                string substr = operationStr.Substring(0, index);
                operationStr = substr + " " + operation;
                resultlable.Text = operationStr;
            }
            else
            {
                Console.WriteLine($"{operationStr} operationList. not Contains{operation}");
                operationStr = operationStr + " " + operation;
                resultlable.Text = operationStr;

            }

            Console.WriteLine($"{operationStr} operationStr done.");

        }

        public string ConvertDot(string txt)
        {

            bool v = txt.Contains(dot.ToString());
            if (v)
            {
                return txt.Replace(dot, '.');
            }

            return txt;
        }

        public string ConvertBackDot(string txt)
        {
            bool v = txt.Contains(".");
            if (v)
            {
                return txt.Replace('.', dot);
            }

            return txt;
        }

        public void SplitStrToList()
        {
            string[] arr = operationStr.Split(' ');

            Console.WriteLine($"work... {operationStr}");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //ex: 3 + 2 = 5
            if (arr.Length > 2)
            {
                answer = DoOperation(Convert.ToDouble(ConvertDot(arr[0])), Convert.ToDouble(ConvertDot(arr[2])), arr[1]);
            }

            //ex: 3+= -> 6, 3*= -> 9, 3-= -> 0, 3/= -> 1
            if (arr.Length == 2 && operationList.Contains(arr[1]))
            {
                answer = DoOperation(Convert.ToDouble(ConvertDot(arr[0])), Convert.ToDouble(ConvertDot(arr[0])), arr[1]);
            }

            Console.WriteLine($"work...done..{answer}");
        }

        public void InitStr()
        {
            //clean default 0 when input 1-9
            if (FirstIsZero(operationStr) && operationStr.Length.Equals(1))
            {
                Console.WriteLine($"FirstIsZero(operationStr) && operationStr.Length.Equals(1)");
                operationStr = "";
                resultlable.Text = operationStr;
            }
        }


        private void nb7label_Click(object sender, EventArgs e)
        {
            InitStr();

            LastIsNotNb();

            operationStr += 7;
            resultlable.Text = operationStr;
        }

        private void nb8label_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();

            operationStr += 8;
            resultlable.Text = operationStr;
        }

        private void nb9label_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();
            operationStr += 9;
            resultlable.Text = operationStr;
        }

        private void divisionlabel_Click(object sender, EventArgs e)
        {
            ChecklastIndex("/");
        }

        private void nb4abel_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();
            operationStr += 4;
            resultlable.Text = operationStr;
        }

        private void nb5label_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();
            operationStr += 5;
            resultlable.Text = operationStr;
        }

        private void nb6label_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();
            operationStr += 6;
            resultlable.Text = operationStr;
        }

        private void multipliedlabel_Click(object sender, EventArgs e)
        {
            ChecklastIndex("*");
        }

        private void nb1label_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();
            operationStr += 1;
            resultlable.Text = operationStr;
        }

        private void nb2label_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();
            operationStr += 2;
            resultlable.Text = operationStr;
        }

        private void nb3label_Click(object sender, EventArgs e)
        {
            InitStr();
            LastIsNotNb();
            operationStr += 3;
            resultlable.Text = operationStr;
        }

        private void minuslabel_Click(object sender, EventArgs e)
        {
            ChecklastIndex("–");
        }

        private int CheckOperationIdx()
        {

            foreach (string item in operationList)
            {
                if (operationStr.Contains(item))
                {
                    //find item index in operationStr
                    idxOperation = operationStr.IndexOf(item);
                }
            }
            return idxOperation;
        }

        private List<string> SliceStr(int nb)
        {
            List<string> list = new List<string> { };
            if (nb != -1)
            {
                sliceStr1 = operationStr.Substring(0, idxOperation);
                sliceStr2 = operationStr.Substring(idxOperation + 1);
                Console.WriteLine($"idxOperation != -1  sliceStr1 {sliceStr1}");
                Console.WriteLine($"idxOperation != -1  sliceStr1 {sliceStr2}");

                list.Add(sliceStr1);
                list.Add(sliceStr2);
            }
            else
            {
                sliceStr1 = operationStr.Substring(0);
                Console.WriteLine($"idxOperation == -1  sliceStr1 {sliceStr1}");
                list.Add(sliceStr1);
            }

            return list;
        }

        private void nb0label_Click(object sender, EventArgs e)
        {

            LastIsNotNb();

            idxOperation = CheckOperationIdx();
            var list = SliceStr(idxOperation);

            Console.WriteLine($"list -> [slicestr1, slicestr2] list[0] {list[0]}");

            if (list.Count > 1)
            {
                Console.WriteLine($"list -> [slicestr1, slicestr2] list[1] {list[1]}");

            }

            if (list.Count == 1)
            {
                //check sliceStr1[0] is  zero

                if (!FirstIsZero(list[0]))
                {
                    operationStr += 0;
                    Console.WriteLine($"sliceStr2 empty, !FirstIsZero(slicestr1) {list[0]}");
                }
                else
                {
                    Console.WriteLine($"sliceStr2 empty, FirstIsZero(slicestr1) {list[0]}");

                }
            }
            else
            {
                //check sliceStr2[0] is  zero
                if (!FirstIsZero(list[1]) && !list[1].Equals(" "))
                {
                    operationStr += 0;
                    Console.WriteLine($"sliceStr2 not empty, !FirstIsZero(slicestr2) {list[1]}");
                }
            }

            resultlable.Text = operationStr;
        }

       
        private void dotlabel_Click(object sender, EventArgs e)
        {
            //check before operation have dot.
            //slice string with operation then check dot.
            idxOperation = CheckOperationIdx();
            var list = SliceStr(idxOperation);

           
            if (list.Count == 2)
            {
             
                //add space and zero
                if(list[1].Equals(""))
                {
                    Console.WriteLine("list[1] is empty.");
                    operationStr += " 0";
                }

                haveDot2 = list[1].Contains(dot.ToString());
                Console.WriteLine($"idxOperation != -1  sliceStr2 {list[1]} havedot {haveDot2}");
          
                AddDot(haveDot2);
            }
            else
            {
                
                haveDot1 = list[0].Contains(dot.ToString());
                Console.WriteLine($"idxOperation == -1  sliceStr0 {list[0]} havedot {haveDot1}");
                AddDot(haveDot1);
            }
        }

        private void AddDot(bool str)
        {
            if (!str)
            {
                operationStr += dot;
                Console.WriteLine($"AddDot false {operationStr}");
            }
        }

        private void pluslabel_Click(object sender, EventArgs e)
        {
            ChecklastIndex("+");
        }

        private void totallabel_Click(object sender, EventArgs e)
        {
            SplitStrToList();

            operationStr = ConvertBackDot(answer.ToString());
            resultlable.Text = operationStr;

        }

        private void clearlabel_Click(object sender, EventArgs e)
        {
            operationStr = "0";
            answer = 0;
            idxOperation = -1;
            resultlable.Text = operationStr;
        }
    }
}
