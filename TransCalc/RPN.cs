using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoRPN
{
    public class RPNcalc
    {
        private string result;
        public string Result //getter
        {
            get
            {
                return result;
            }
        }

        //private string errors = "none";
        /*public string Errors //getter
        {
            get
            {
                return errors;
            }
        }*/

        private string rpn;
        public string RPN //getter
        {
            get
            {
                return rpn;
            }
        }

        private double Operate(double a, double b, string operation)
        {

            switch (operation)
            {
                case "+": return (a + b);
                case "-": return (b - a);
                case "*": return (a * b);
                case "/": return (b / a);
                default: return 0;
            } //calculates numbers taken from stack, i.e. they are backward

        }

        private int IsFunc(string inSymbol)
        {
            //symbol priority checking
            if (Double.TryParse(inSymbol, out double checknumber)) return 1;
            else if (inSymbol == " ") return 2;
            else if (inSymbol == "(") return 3;
            else if (inSymbol == ")") return 4;
            else if ((inSymbol == "+") || (inSymbol == "-")) return 5;
            else if ((inSymbol == "*") || (inSymbol == "/")) return 6;

            else return 0;
        }

        private double Do (double a, double b, string symb) {
            rpn += symb; rpn += " ";
            return (Operate(a, b, symb));
        }

        public void Calculate(string input)
        {
            string inSymbol = "";
            bool prevNum = false; //if previous symbol was a digit
            var NumStack = new Stack<double>();
            var OperStack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                inSymbol = Convert.ToString(input[i]);

                if (IsFunc(inSymbol) == 0)
                {
                    throw new Exception("Unknown symbol detected");
                }
                else if (IsFunc(inSymbol) == 1)
                {
                    if ((NumStack.Count > 0) & prevNum)
                    { //if stack is not empty and previous symbol was a digit: the new digit is considered a part of the number
                        NumStack.Push(NumStack.Pop() * 10 + Convert.ToDouble(inSymbol));
                        rpn = rpn.Remove(rpn.Length - 1);
                        rpn += inSymbol;
                        rpn += " ";
                    }
                    else
                    {
                        NumStack.Push(Convert.ToDouble(inSymbol));
                        rpn += inSymbol;
                        rpn += " ";
                    }
                    prevNum = true; //tells the next symbol that the previous one was a number
                }
                else
                {
                    prevNum = false; //the symbol is *not* a number

                    //if there are: + - * / symbols then the program checks the stack of operations
                    //if there are operators with equal or higher priority in there then their operations get executed
                    //and a newly input symbol is put into the stack

                    switch (IsFunc(inSymbol))
                    {
                        case 5:
                            if (OperStack.Count > 0)
                            {
                                while (OperStack.Count > 0)
                                {
                                    if (IsFunc(OperStack.Peek()) >= 5)
                                    {
                                        NumStack.Push(Do(NumStack.Pop(), NumStack.Pop(), OperStack.Pop()));
                                    }
                                    else break; //no more operators with suitable priority
                                }
                                OperStack.Push(inSymbol);
                            }
                            else OperStack.Push(inSymbol);
                            break;

                        case 6:
                            if (OperStack.Count > 0)
                            {
                                while (OperStack.Count > 0)
                                {
                                    if (IsFunc(OperStack.Peek()) >= 6)
                                    {
                                        NumStack.Push(Do(NumStack.Pop(), NumStack.Pop(), OperStack.Pop()));
                                    }
                                    else break; //no more operators with suitable priority
                                }
                                OperStack.Push(inSymbol);
                            }
                            else OperStack.Push(inSymbol);
                            break;

                        case 3: OperStack.Push(inSymbol); break;
                        //if there's an opening bracket it gets put into the stack of operations

                        case 4:
                            while (OperStack.Count > 0)
                            {
                                //every operation between the brackets gets executed
                                if (IsFunc(OperStack.Peek()) != 3)
                                {
                                    NumStack.Push(Do(NumStack.Pop(), NumStack.Pop(), OperStack.Pop()));
                                }
                                else break;
                            }
                            OperStack.Pop(); //the opening ( bracket is deleted from stack
                            break;
                    }
                }
            }
            
            while (OperStack.Count > 0)
            {
                if (NumStack.Count > 1)
                NumStack.Push(Do(NumStack.Pop(), NumStack.Pop(), OperStack.Pop()));
                else
                {
                    throw new Exception("Not enough numbers to operate");                    
                }
            } //all the operations remaining in the stack are executed



            rpn = rpn.Remove(rpn.Length - 1);
            result = Convert.ToString(NumStack.Pop());
        }
    }
}
