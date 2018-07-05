using System.Linq;

namespace Folivora
{
    public class Permutation
    {
        public static double PredictNext(params double[] permutation)
        {
            if (TryParseConst(permutation, out double next))
                return next;
            if (TryParseLinearSeq(permutation, out next))
                return next;
            if (TryParseGeometricSeq(permutation, out next))
                return next;

            throw new System.Exception();
        }

        static bool TryParseConst(double[] nums, out double next)
        {
            double num = nums[0];
            next = num;
            foreach (var n in nums)
                if (num != n)
                    return false;
            return true;
        }

        static bool TryParseLinearSeq(double[] nums, out double next)
        {
            next = 0;
            if (nums.Length < 3)
            {
                // Not enough numbers
                return false;
            }

            double delta = nums[1] - nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (delta != nums[i + 1] - nums[i])
                {
                    return false;
                }
            }

            next = nums.Last() + delta;
            return true;
        }

        static bool TryParseGeometricSeq(double[] nums, out double next)
        {
            next = 0;
            if (nums.Length < 3)
            {
                // Not enough numbers
                return false;
            }

            if (nums.Contains(0))
            {
                // 모두 0이 아니면 등비수열이 아님
                return false;
            }

            double delta = nums[1] / nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (delta != nums[i + 1] / nums[i])
                {
                    return false;
                }
            }

            next = nums.Last() * delta;
            return true;
        }
    }
}
