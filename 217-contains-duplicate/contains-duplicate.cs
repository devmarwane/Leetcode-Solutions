public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> dict = new HashSet<int>();

        for(int i=0;i<nums.Length;i++){
            if (dict.Contains(nums[i]))
                return true;
            else
                dict.Add(nums[i]);
        }
        return false;
    }
}