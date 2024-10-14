public class Solution {
    public void MoveZeroes(int[] nums) {

        int filled=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] != 0){
                nums[filled++] = nums[i];
            }
        }
        for(int i=filled;i<nums.Length;i++){
            nums[i]=0;
        }
        
            
    }
}