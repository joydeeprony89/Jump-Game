using System;

namespace Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var validNums = new int[] {1,1,2,0,4};
            var invalidNums = new int[] { 0, 1, 2, 0, 4 };
            Console.WriteLine(CanJump_StartFromBegining(validNums));
            Console.WriteLine(CanJump_StartFromEnd(invalidNums));
        }

        static bool CanJump_StartFromBegining(int[] nums)
        {
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (i > max) return false;
                max = Math.Max(i + nums[i], max);
                if (max >= nums.Length - 1) return true;
            }
            return true;
        }

        static bool CanJump_StartFromEnd(int[] nums)
        {
            int positionTillWeCanReach = nums.Length - 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= positionTillWeCanReach)
                    positionTillWeCanReach = i;
            }
            return positionTillWeCanReach == 0;
        }
    }
}
