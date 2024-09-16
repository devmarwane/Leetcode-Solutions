public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;
        if (nums.Length == 1)
        {
            if (nums[0] == val)
                return 0;
            else
                return 1;
        }

        int leftPointer = 0;
        int rightPointer = nums.Length - 1;
        int cpt = 0;


        while (leftPointer <= rightPointer)
        {
            if (nums[rightPointer] == val)
            {
                rightPointer--;
                cpt++;
            }
            else
            {
                if (nums[leftPointer] != val)
                {
                    leftPointer++;
                }
                else
                {
                    int tmp = nums[leftPointer];
                    nums[leftPointer] = nums[rightPointer];
                    nums[rightPointer] = tmp;
                    rightPointer--;
                    cpt++;

                }

            }
        }            

        return nums.Length - cpt;
    }
}