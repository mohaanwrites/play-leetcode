using Leetcode._002_IntegerReverser;
using Xunit;

namespace Leetcode.Tests._002_IntegerReverser
{
	public class IntegerReverserTests
	{
		[Fact]
		public void PositiveNumberReturnsReversedInteger()
		{
			Assert.Equal(001, IntegerReverser.Reverse(100));
			Assert.Equal(-321, IntegerReverser.Reverse(-123));
			Assert.Equal(0, IntegerReverser.Reverse(0));
		}

		[Fact]
		public void NumberBeyondPositiveIntegerLimitReturnsZero()
		{
			Assert.Equal(0, IntegerReverser.Reverse(int.MaxValue));
		}

		[Fact]
		public void NumberBeyondNegativeIntegerLimitReturnsZero()
		{
			Assert.Equal(0, IntegerReverser.Reverse(int.MinValue));
		}

		[Fact]
		public void NumberUptoPositiveIntegerLimitReturnsReversedInteger()
		{
			Assert.Equal(2517902, IntegerReverser.Reverse(2097152));
		}

		[Fact]
		public void NumberUptoNegativeIntegerLimitReturnsReversedInteger()
		{
			Assert.Equal(-2517902, IntegerReverser.Reverse(-2097152));
		}

		[Fact]
		public void NumberNextPositiveIntegerLimitReturnsReversedInteger()
		{
			Assert.Equal(0, IntegerReverser.Reverse(2147483647));
		}

		[Fact]
		public void NumberNextNegativeIntegerLimitReturnsReversedInteger()
		{
			Assert.Equal(0, IntegerReverser.Reverse(-2147483647));
		}
	}
}