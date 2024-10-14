public class Solution {
    public void MoveZeroes(int[] nums) {
        int lastNonZeroIndex = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            // When we encounter a non-zero element, we swap it with the element at the last known non-zero index
            if (nums[i] != 0) {
                int temp = nums[lastNonZeroIndex];
                nums[lastNonZeroIndex] = nums[i];
                nums[i] = temp;
                lastNonZeroIndex++;
            }
        }
    }
}