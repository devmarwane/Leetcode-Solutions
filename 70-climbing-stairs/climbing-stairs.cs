public class Solution {
    public int ClimbStairs(int n)
    {
        if (n == 1 )
            return 1;

        Dictionary<int, int> map  = new Dictionary<int, int>();

        return ClimbStairsHelper(n, map);
    }

    private int ClimbStairsHelper(int n, Dictionary<int, int> map)
    {
        if (n == 1 || n==0)
            return 1;

        if (map.ContainsKey(n))
            return map[n];


        int val= ClimbStairsHelper(n - 1, map) + ClimbStairsHelper(n - 2, map);
        map.Add(n, val);
        return val;
    }

}