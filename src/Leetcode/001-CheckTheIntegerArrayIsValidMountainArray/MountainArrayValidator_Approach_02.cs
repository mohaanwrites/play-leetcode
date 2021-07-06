namespace Leetcode._001_CheckTheIntegerArrayIsValidMountainArray
{
	public class MountainArrayValidator_Approach_02 : IValidMountainArrayValidator
	{
		public bool IsValidMountainArray(int[] array)
		{
			int arrayIdx = array.Length - 1;

			if (arrayIdx < 2)
				return false;

			int itr = 0;

			//Increasing pattern, find peak.
			while (arrayIdx > itr && array[itr + 1] > array[itr])
			{
				itr++;
			}

			//Peak should not be start or last.
			if (itr == 0 || itr == arrayIdx)
				return false;

			//Decreasing pattern, until end.
			while (arrayIdx > itr && array[itr + 1] < array[itr])
			{
				itr++;
			}

			return itr == arrayIdx;
		}
	}
}
