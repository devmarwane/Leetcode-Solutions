public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (k==0)
            return false;
            
        Queue<int> numbers = new Queue<int>();

        for(int i=0;i<nums.Length;i++) {
            if (numbers.Contains(nums[i])){
                return true;
            }
            AddToQueue(numbers, nums[i],k);

        }
        return false;
    }

    private void AddToQueue(Queue<int> q,int num, int maxItems) {
        if (q.Count==maxItems){
            q.Dequeue();
        }
        q.Enqueue(num);
    }
}