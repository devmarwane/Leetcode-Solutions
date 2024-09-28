public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        
        int minSubArray = nums.Length+1;
        int l=0, r=0;

        int sum=0;

        while(r<nums.Length)
        {       

            sum+=nums[r];

             while (sum>=target){
                minSubArray=Math.Min(r-l+1,minSubArray);
                sum=sum-nums[l];
                l++;
            }
            r++;
        }

        if(minSubArray==nums.Length+1)
            return 0;
        return minSubArray;
    }
}