public class Solution {
    public string ReverseVowels(string s) {
        int l=0, r = s.Length-1;
        char[] chars = s.ToCharArray();
        while(l<r){
            if (!isVoyel(chars[l])){
                l++;
            }
            else if(!isVoyel(chars[r])){
                r--;
            }
            else{
                var tmp = chars[l];
                chars[l] = chars[r];
                chars[r] = tmp;
                l++;
                r--;
            }
        }
        return new string(chars);
    }

    private bool isVoyel(char a){
        char x=char.ToLowerInvariant(a);
        return x=='a' || x=='e' || x=='i' || x=='o' || x=='u';
    }
}