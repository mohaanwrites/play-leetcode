using Xunit;

namespace Leetcode.Tests._001_CheckTheIntegerArrayIsValidMountainArray
{
	using Leetcode._001_CheckTheIntegerArrayIsValidMountainArray;

	public class MountainArrayValidatorTests
	{
		private static readonly IValidMountainArrayValidator mountainValidator_v1 = new MountainArrayValidator_Approach_01();
		private static readonly IValidMountainArrayValidator mountainValidator_v2 = new MountainArrayValidator_Approach_01();

		[Theory]
		[InlineData(new int[] { 0 })]
		[InlineData(new int[] { 0, 1 })]
		public void MountainArrayValidatorReturnFalseForArraySizeLessThanOrEqualsThree(int[] array)
		{
			Assert.False(mountainValidator_v1.IsValidMountainArray(array));
			Assert.False(mountainValidator_v2.IsValidMountainArray(array));
		}

		[Theory]
		[InlineData(new int[] { 0, 1, 2, 2 })]
		[InlineData(new int[] { 0, 1, 2, 2, 1 })]
		public void MountainArrayValidatorReturnFalseForAInvalidPatterns(int[] array)
		{
			Assert.False(mountainValidator_v1.IsValidMountainArray(array));
			Assert.False(mountainValidator_v2.IsValidMountainArray(array));
		}

		[Theory]
		[InlineData(new int[] { 1, 3, 2 })]
		[InlineData(new int[] { 0, 1, 2, 1 })]
		[InlineData(new int[] { 0, 1, 2, 1, 0 })]
		public void MountainArrayValidatorReturnTrueForAValidPatterns(int[] array)
		{
			Assert.True(mountainValidator_v1.IsValidMountainArray(array));
			Assert.True(mountainValidator_v2.IsValidMountainArray(array));
		}

		[Theory]
		[InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
		[InlineData(new int[] { 0, 10, 100, 1000, 10000, 100000, 1000000, 1000000 })]
		public void EverIncreasingPatternReturnsFalse(int[] array)
		{
			Assert.False(mountainValidator_v1.IsValidMountainArray(array));
			Assert.False(mountainValidator_v2.IsValidMountainArray(array));
		}

		[Theory]
		[InlineData(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
		[InlineData(new int[] { 99, 89, 79, 69, 59, 49, 39, 29, 19, 0 })]
		public void EverDecreasingPatternReturnsFalse(int[] array)
		{
			Assert.False(mountainValidator_v1.IsValidMountainArray(array));
			Assert.False(mountainValidator_v2.IsValidMountainArray(array));
		}
	}
}