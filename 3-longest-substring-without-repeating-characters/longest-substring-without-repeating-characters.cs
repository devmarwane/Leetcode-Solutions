public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int longestSubstring = 0;

        int l=0, r=0;

        Dictionary<char,int> chars = new Dictionary<char,int>();

        for(r=0;r<s.Length;r++) {

            if (!chars.ContainsKey(s[r]) || (chars.ContainsKey(s[r]) && chars[s[r]]<l)){
                //chars.Add(s[r],r);
                chars[s[r]]=r;
                longestSubstring = Math.Max(r-l+1,longestSubstring) ;                
            }else{

                int oldIndex = chars[s[r]];
                l=Math.Max(oldIndex+1, 0);
                chars[s[r]] = r;
            }
        } 

        return longestSubstring;
    }
}