using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip_Test.Models
{
    public class Calculator
    {
        private int result;
        private List<object> operationHistory = new List<object>();
        private List<string> operationTypes = new List<string>();
        private int historyIndex = -1;

        public Calculator(int initialValue)
        {
            result = initialValue;
        }

        public int Result => result;

        public void ProcessCommand(string command)
        {
            switch (command.ToLower())
            {
                case "increment":
                    var incOp = new Increment();
                    result = incOp.Execute(result);
                    operationHistory.Add(incOp);
                    operationTypes.Add("increment");
                    historyIndex++;
                    break;

                case "decrement":
                    var decOp = new Decrement();
                    result = decOp.Execute(result);
                    operationHistory.Add(decOp);
                    operationTypes.Add("decrement");
                    historyIndex++;
                    break;

                case "double":
                    var doubleOp = new Double();
                    result = doubleOp.Execute(result);
                    operationHistory.Add(doubleOp);
                    operationTypes.Add("double");
                    historyIndex++;
                    break;

                case "randadd":
                    var randOp = new Randadd();
                    result = randOp.Execute(result);
                    operationHistory.Add(randOp);
                    operationTypes.Add("randadd");
                    historyIndex++;
                    break;

                case "undo":
                    Undo();
                    break;

                default:
                    Console.WriteLine("Command is unknown. Available commands: increment, decrement, double, randadd, undo");
                    break;
            }
        }

        private void Undo()
        {
            if (historyIndex >= 0)
            {
                string opType = operationTypes[historyIndex];

                switch (opType)
                {
                    case "increment":
                        result = ((Increment)operationHistory[historyIndex]).Undo(result);
                        break;
                    case "decrement":
                        result = ((Decrement)operationHistory[historyIndex]).Undo(result);
                        break;
                    case "double":
                        result = ((Double)operationHistory[historyIndex]).Undo(result);
                        break;
                    case "randadd":
                        result = ((Randadd)operationHistory[historyIndex]).Undo(result);
                        break;
                }

                historyIndex--;
            }
            else
            {
                Console.WriteLine("Undo history is empty!");
            }
        }
    }
}
