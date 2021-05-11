using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnit_Assignment_9
{
    public class StringCheck : Constraint
    {
        readonly string _expected;

        public StringCheck(string expected)
        {
            _expected = char.ToLower(expected[0]) + expected.Substring(1);

            Description = $"Expected is {expected}";
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            if (typeof(TActual) != typeof(string))
                return new ConstraintResult(this, actual, ConstraintStatus.Error);
            if (_expected == actual.ToString())
                return new ConstraintResult(this, actual, ConstraintStatus.Success);
            else
                return new ConstraintResult(this, actual, ConstraintStatus.Failure);
        }
    }

    public class UpperStringChecker : Constraint
    {
        readonly string _secondExpected;
        public UpperStringChecker(string expects)
        {
            _secondExpected = char.ToUpper(expects[0]) + expects.Substring(1);
            Description = $"Expected Value is {expects}";
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            if (typeof(TActual) != typeof(string))
                return new ConstraintResult(this, actual, ConstraintStatus.Error);
            if (_secondExpected == actual.ToString())
                return new ConstraintResult(this, actual, ConstraintStatus.Success);
            else
                return new ConstraintResult(this, actual, ConstraintStatus.Failure);
        }
    }
    public class Is : NUnit.Framework.Is
    {
        public static StringCheck IsLower(string expected)
        {
            return new StringCheck(expected);
        }

        public static UpperStringChecker IsUpper(string expects)
        {
            return new UpperStringChecker(expects);
        }
    }
}
