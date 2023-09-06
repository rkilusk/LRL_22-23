using System.Data;
using System.Text;
using System;

namespace CalculatorLib
{
    public class Calculator
    {
        private StringBuilder _input;
        private decimal? _result;

        public Calculator()
        {
            _input = new StringBuilder();
        }

        public void KeyPress(char key)
        {
            if (key == '=')
            {
                try
                {
                    _result = EvaluateExpression(_input.ToString());
                }
                catch (Exception)
                {
                    _result = null;
                }

                _input.Clear();
            }
            else if (key == 'C')
            {
                _input.Clear();
                _result = null;
            }
            else
            {
                _input.Append(key);
            }
        }

        public decimal? Result
        {
            get
            {
                return _result;
            }
        }

        private decimal EvaluateExpression(string expression)
        {
            if (_result.HasValue)

            {
                expression = expression.Replace("C", _result.Value.ToString());
            }
            var table = new System.Data.DataTable();
            var result = table.Compute(expression, "");
            return Convert.ToDecimal(result);
        }
    }
}