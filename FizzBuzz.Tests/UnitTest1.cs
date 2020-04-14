using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void WhenFizzBuzzNumber1_StringOf1Returned()
        {
            var fb = new FizzBuzz();
            
            var res = fb.DoFizzBuzz(1);

            res.Should().Be("1");

        }
    }
}
