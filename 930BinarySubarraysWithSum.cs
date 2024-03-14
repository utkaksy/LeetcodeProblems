public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {

        int toplam = 0;
        int output = 0;
        //toplam=0
        //output=4
        //i=3
        //j=3
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                toplam = toplam + nums[j];
                if (toplam == goal)
                {
                    output++;
                }
            }
            toplam = 0;
        }
        return output;

    }
}