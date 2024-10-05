public class Solution {

     public int Fib(int n) {
        if (n<2)
            return n;

        int[] fNumbers = new int[n+1];

        fNumbers[0] = 1;
        fNumbers[1] = 1;

        for(int i=2;i<n;i++){
            fNumbers[i]=fNumbers[i-1]+fNumbers[i-2];
        }

        return fNumbers[n-1];
    }
}