using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
       
  
        if (string.IsNullOrWhiteSpace(s))
            return true;

        int l=0;
        int r=s.Length-1;

        while(l<r){
            if (!char.IsLetterOrDigit(s[l]))
                l++;
            else if (!char.IsLetterOrDigit(s[r]))
                r--;
            else
            {
                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                    return false;
                
                l++;
                r--;
            }
        }

        return true;
    }
}