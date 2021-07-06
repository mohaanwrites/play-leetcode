namespace Leetcode._003_TwoSum
{
	public static class TwoSum
	{
		public static int[] Find(int[] nums, int target)
		{
            int arrayLength = nums.Length;
            int[] outputIndices = new int[2];

            for (int itr = 0; itr < arrayLength; itr++)
            {
                for (int jtr = itr + 1; jtr < arrayLength; jtr++)
                {
                    if (nums[itr] + nums[jtr] == target)
                    {
                        outputIndices[0] = itr;
                        outputIndices[1] = jtr;
                        break;
                    }
                }
            }
            return outputIndices;
        }
	}
}