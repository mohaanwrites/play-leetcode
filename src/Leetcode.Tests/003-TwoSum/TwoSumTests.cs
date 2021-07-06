using Leetcode._003_TwoSum;
using Xunit;

namespace Leetcode.Tests._003_TwoSum
{
	public class TwoSumTests
	{
		[Theory]
		[InlineData(new int[] { 0, 1, 2, 3 })]
		public void ValidTwoSumReturnsIndices(int[] dataSet)
		{
			Assert.Collection(TwoSum.Find(dataSet, 5), item => Assert.Equal(2, item), item => Assert.Equal(3, item));
			Assert.Collection(TwoSum.Find(dataSet, 2), item => Assert.Equal(0, item), item => Assert.Equal(2, item));
		}

		[Theory]
		[InlineData(new int[] { 0, 1, 2, 3 })]
		public void InValidTwoSumReturnsEmptyIndices(int[] dataSet)
		{
			Assert.Collection(TwoSum.Find(dataSet, 6), item => Assert.Equal(0, item), item => Assert.Equal(0, item));
		}

		[Theory]
		[InlineData(new int[] { 0, 1, 1, 2, 3 })]
		public void MultipleCombosReturnsFirstInstance(int[] dataSet)
		{
			Assert.Collection(TwoSum.Find(dataSet, 1), item => Assert.Equal(0, item), item => Assert.Equal(1, item));
			Assert.Collection(TwoSum.Find(dataSet, 2), item => Assert.Equal(1, item), item => Assert.Equal(2, item));
		}
	}
}
