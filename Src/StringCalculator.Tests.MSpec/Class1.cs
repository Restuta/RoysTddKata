using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Machine.Specifications.Annotations;
using StringCalculator.Core;

namespace StringCalculator.Tests.MSpec
{
    [Subject(typeof(SimpleStringCalculator))]
    public class when_add_method_is_invoked
    {
        private static SimpleStringCalculator simpleStringCalculator;
        private static int result = -1;

        Establish context = () => simpleStringCalculator = new SimpleStringCalculator();

        Because of = () => result = simpleStringCalculator.Add(string.Empty);

        It should_return_a_zero = () => result.ShouldEqual(0);
    }
}
