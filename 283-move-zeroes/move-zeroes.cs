public class Solution {
    public void MoveZeroes(int[] nums) {

        int filled=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] != 0){
                if(i!=filled){
                    nums[filled] = nums[i];
                    nums[i]=0;
                }
                filled++;
            }
        }          
    }
}