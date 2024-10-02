public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i=0;
        string output="";
        while(i<word1.Length || i<word2.Length){
            if (i<word1.Length)
                output+=word1[i];
            if (i<word2.Length)
                output+=word2[i];
            i++;
        }

        return output;
    }
}