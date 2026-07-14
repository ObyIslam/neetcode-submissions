public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        int left = 1;
        int right = piles.Max();

        while(left <= right)
        {
            int mid = (left + right) / 2;

            if(CanFinish(piles, h, mid))
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }


    private bool CanFinish(int[] piles, int h, int speed)
    {
        int hours = 0;

        foreach(int pile in piles)
        {
            hours += (int)Math.Ceiling((double)pile / speed);
        }

        return hours <= h;
    }
}