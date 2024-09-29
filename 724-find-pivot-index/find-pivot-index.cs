public class Solution {
    public int PivotIndex(int[] nums) {
        
        int[] sumNums = new int[nums.Length];
        int sum=0;

        for(int i=0;i<nums.Length;i++) {
            sum += nums[i];
            sumNums[i] = sum;
        }

        for(int i=0;i<nums.Length;i++){
            int left = GetSum(sumNums, 0, i);
            int right = GetSum(sumNums, i, nums.Length-1);
            if (left == right)
                return i;
        }
        return -1;

    }

    private int GetSum(int[] nums, int leftIndex, int rightIndex){
        int preRight = nums[rightIndex];
        int preLeft = leftIndex > 0 ? nums[leftIndex-1] : 0;
        return preRight - preLeft;
    }
}