namespace Leetcode
{
	using System;
	using System.Collections.Generic;
	using _001_CheckTheIntegerArrayIsValidMountainArray;

	class Program
	{
		static void Main(string[] args)
		{
			List<IValidMountainArrayValidator> mountainArrImpl = new List<IValidMountainArrayValidator>() { new MountainArrayValidator_Approach_01(), new MountainArrayValidator_Approach_02() };

			foreach (IValidMountainArrayValidator mntImpl in mountainArrImpl)
			{
				Console.WriteLine($"{mntImpl.GetType()} : {mntImpl.IsValidMountainArray(new int[] { 0, 5, 7, 7, 5, 0 })}");
			}

			Console.Read();
		}
	}
}