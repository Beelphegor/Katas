using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Machine.Specifications;

namespace DevTests.CSharp.StringCalculator
{
    public class when_calculating_strings
    {
        It should_be_able_to_add_1_and_1 = () => Calculator.Calculate("1+1").ShouldEqual(2);

        It should_be_able_to_add_2_and_2 = () => Calculator.Calculate("2+2").ShouldEqual(4);

        It should_be_able_to_add_multiple_numbers = () => Calculator.Calculate("11+20+42").ShouldEqual(73);

        It should_be_able_to_subtract_10_and_5 = () => Calculator.Calculate("10-5").ShouldEqual(5);

        It should_be_able_to_subtract_5_and_3 = () => Calculator.Calculate("5-3").ShouldEqual(2);

        It should_be_able_to_subtract_multiple_numbers = () => Calculator.Calculate("11-5-10").ShouldEqual(-4);
    }
}
