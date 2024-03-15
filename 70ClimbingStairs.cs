public class Solution
{
    public int ClimbStairs(int n)
    {
        bool b = true;
        int toplam1 = 2; int toplam2 = 1;

        if (n == 1)
        {
            return toplam2;
        }

        for (int i = 2; i < n; i++)
        {
            if (b)
            {
                toplam2 += toplam1;
            }
            else
            {
                toplam1 += toplam2;
            }
            b = !b;
        }
        if (b)
        {
            return toplam1;
        }
        else
        {
            return toplam2;
        }
    }
}