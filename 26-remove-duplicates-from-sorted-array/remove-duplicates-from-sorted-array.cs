public class Solution {
     public int RemoveDuplicates(int[] nums) {
        int i=0, j=1;

        while(j<nums.Length) {
            if (nums[i] == nums[j]){
                j++;
            } else {
                int tmp = nums[i+1];
                nums[i+1] = nums[j];
                nums[j] = tmp; 
                i++;
                j++;
            }
        }

        return i+1;
            
    }
    
}