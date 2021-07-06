namespace Leetcode._002_IntegerReverser
{
	public static class IntegerReverser
    {
        public static int Reverse(int x)
        {
            bool isNegative = x < 0;
            string inputString = (x * (isNegative ? -1 : 1)).ToString();
            string reversedString = string.Empty;

            foreach (char c in inputString)
            {
                reversedString = c + reversedString;
            }

            int.TryParse(reversedString, out int reversedNum);

            return reversedNum * (isNegative ? -1 : 1);
        }
    }
}
