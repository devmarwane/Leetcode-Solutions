public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for(int i=0;i<nums.Length-1;i++) {
            for(int j=i+1; j<Math.Min(nums.Length,i+1+k);j++){

                if (i != j && nums[i]==nums[j])
                    return true;
            }
        }
        return false;
    }
}