public class Solution {
    public bool IsPowerOfTwo(int n) {
       if (n == 0)
            return false;
        
        if (n == 1 || n ==  2)
            return true;


        int x=1;
        int sum = 2;
        while(x<n){
            sum*=2;
            if (sum == n)
                return true;
            x++;
        }
        return false;
    }
}