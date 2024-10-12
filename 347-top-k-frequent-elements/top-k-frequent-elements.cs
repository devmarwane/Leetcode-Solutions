public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> numsFrequency = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if (!numsFrequency.TryAdd(nums[i],1)){
                numsFrequency[nums[i]] = numsFrequency[nums[i]]+1;
            }
        }

        return numsFrequency.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
    }
}