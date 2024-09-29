public class NumArray {

    int[] prefix;
    public NumArray(int[] nums) {
        prefix = new int[nums.Length];
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
            prefix[i]=sum;
        }
    }
    
    public int SumRange(int left, int right) {
        int sumRight = prefix[right];
        int sumLeft = left<=0?0:prefix[left-1];
        return sumRight - sumLeft;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */