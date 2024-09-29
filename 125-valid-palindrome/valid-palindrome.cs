using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        // remove all non-alphanumeric characters
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        s = rgx.Replace(s, "");
        //Remove empty spaces & convert uppercase letters into lowercase
        s=s.ToLower().Replace(" ","");
        if (string.IsNullOrEmpty(s))
            return true;

        int l=0;
        int r=s.Length-1;

        while(l<(s.Length/2)+1){
            if (s[l]!=s[r])
                return false;

            l++;
            r--;
        }

        return true;
    }
}