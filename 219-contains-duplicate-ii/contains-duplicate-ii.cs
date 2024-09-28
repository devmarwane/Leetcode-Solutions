public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (k==0)
            return false;


        HashSet<int> window = new HashSet<int>();
        int l=0;

        for(int r=0;r<nums.Length;r++){
            if(r-l>k) {
                window.Remove(nums[l]);
                l++;
            }

            if(window.Contains(nums[r]))
            {
                return true;
            }
    
            window.Add(nums[r]);

        }
        return false;
    }

}