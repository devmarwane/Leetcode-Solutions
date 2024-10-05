public class Solution {
    public int Fib(int n) {
        Dictionary<int,int> memo = new Dictionary<int,int>();
        return FibHelper(n, memo);
    }

    private int FibHelper(int n, Dictionary<int,int> memo)
    {
        if (n == 0)
            return 0;
        
        if (n == 1)
            return 1;
        
        int n1, n2;
        if (!memo.ContainsKey(n-1)){
            n1 = FibHelper(n-1, memo);
            memo.Add(n-1, n1);
        }
        else{
            n1 = memo[n-1];
        }

        if (!memo.ContainsKey(n-2)){
            n2 = FibHelper(n-2, memo);
            memo.Add(n-2, n2);
        }
        else{
            n2 = memo[n-2];
        }

        return n1 + n2;
    }
}