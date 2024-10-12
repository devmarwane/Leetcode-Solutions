public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        int[] topK = new int[k];

        Dictionary<int,int> numsFrequency = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if (!numsFrequency.TryAdd(nums[i],1)){
                numsFrequency[nums[i]] = numsFrequency[nums[i]]+1;
            }
        }

        //Use a priority queue (min-heap) to track the top k frequent elements
        var pq = new PriorityQueue<int, int>();
        // Iterate over the frequency map and add each element to the priority queue
        foreach (var key in numsFrequency.Keys)
        {
            pq.Enqueue(key, numsFrequency[key]);// Add element and its frequency as priority
            if (pq.Count > k) pq.Dequeue();  // Keep only top k elements in the priority queue
        }

        //Extract elements from the priority queue and store them in the result array
        int index = k;
        while (pq.Count > 0) {
            topK[--index] = pq.Dequeue();//// Dequeue the elements in reverse order into topK
        }
        return topK;
    }
}