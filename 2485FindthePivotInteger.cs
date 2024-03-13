public class Solution
{
    public int PivotInteger(int n)
    {

        int sol = 0, sag = 0;
        for (int i = 1; i <= n; i++)
        {

            sol = (i * (i + 1)) / 2;
            sag = ((n * (n + 1)) / 2) - sol + i;

            if (sol == sag)
            {
                return i;
            }
        }
        return -1;
    }
}