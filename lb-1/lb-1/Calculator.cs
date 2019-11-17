namespace lb_1
{
    abstract class Calculator
    {
        public abstract double Number { set; }
        public abstract string Sign { set; }
        public abstract double Result { get; } 
    }

    sealed class CasualCalculator : Calculator
    {
        private string sign;
        private double leftOperand;
        private double rightOperand;
        private double result;
        private bool isFirst = true;
        Evaluator.CasualEvaluator casualEvaluator = new Evaluator.CasualEvaluator();

        public override double Number
        {
            set
            {
                if (isFirst)
                {
                    leftOperand = value;
                    isFirst = false;
                }
                else
                {
                    rightOperand = value;
                    leftOperand = casualEvaluator.Result(sign, leftOperand, rightOperand);
                    result = leftOperand;
                }
            }
        }

        public override string Sign
        {
            set
            {
                sign = value;
            }
        }

        public override double Result
        {
            get
            {
                return result;
            }
        }
    }
    sealed class EngineerCalculator : Calculator
    {
        private string sign;
        private double number;
        Evaluator.EngineerEvaluator engineerEvaluator = new Evaluator.EngineerEvaluator();

        public override double Number
        {
            set
            {
                number = value;
            }
        }

        public override string Sign
        {
            set
            {
                sign = value;
            }
        }

        public override double Result
        {
            get
            {
                return engineerEvaluator.Result(sign, number);
            }
        }
    }
}
