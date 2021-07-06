namespace Leetcode._001_CheckTheIntegerArrayIsValidMountainArray
{
	public class MountainArrayValidator_Approach_01 : IValidMountainArrayValidator
	{
		public bool IsValidMountainArray(int[] array)
		{
			int arrayIdx = array.Length - 1;

			if (arrayIdx < 2)
				return false;

			int itr = 0;
			bool increasing = false;

			while (arrayIdx > itr)
			{
				bool bln = array[itr + 1] > array[itr];
				if (!increasing && !bln)
				{
					increasing = true;
				}

				if (increasing)
				{
					if (itr == 0) return false;

					bool bln2 = array[itr + 1] < array[itr];
					if (!bln2)
						break;
				}
				itr++;
			}

			return increasing && itr == arrayIdx;
		}
	}
}