public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i=0;
        int k=0;
        char[] output= new char[word1.Length+word2.Length];
        while(i<word1.Length || i<word2.Length){
            if (i<word1.Length)
                output[k++] = word1[i];
            if (i<word2.Length)
                output[k++] = word2[i];
            i++;
        }

        return new string(output);
    }
}