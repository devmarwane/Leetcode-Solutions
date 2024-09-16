public class Solution {
         public int[] TwoSum(int[] nums, int target)
 {
     Dictionary<int, int> hash = new Dictionary<int, int>();
     for (int i = 0; i < nums.Length; i++)
     {
         var r = target - nums[i];
         
         if (hash.ContainsKey(r))
         {
             return new int[] { hash[r], i };
         }
         else if (!hash.ContainsKey(nums[i]))
         {
             hash.Add(nums[i], i);
         }
     }
     return new int[] { -1, -1 };
 }
}