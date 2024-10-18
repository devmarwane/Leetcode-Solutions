public class Solution {
    public int MaxDepth(string s) {
    
        int cpt=0;
        int max=0;

        for(int i=0;i<s.Length;i++){
            if(s[i]=='(')
                cpt++;
            else if (s[i]==')')
                cpt--;
            
            max = Math.Max(cpt, max);
        }

        return max;
    }
}