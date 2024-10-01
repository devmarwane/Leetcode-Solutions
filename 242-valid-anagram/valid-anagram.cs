public class Solution {
    public bool IsAnagram(string s, string t) {
        // Initialize a dictionary to store the frequency of characters
        Dictionary<char, int> hash = new Dictionary<char, int>();

        // Iterate through the first string 's'
        for (int i = 0; i < s.Length; i++) {
            // Try to get the current value of the character s[i]
            if (hash.TryGetValue(s[i], out int count)) {
                // If the character exists, increment its count
                hash[s[i]] = count + 1;
            } else {
                // If the character doesn't exist, initialize its count to 1
                hash[s[i]] = 1;
            }
        }

        // Iterate through the second string 't'
        for (int i = 0; i < t.Length; i++) {
            // Try to get the current value of the character t[i]
            if (hash.TryGetValue(t[i], out int count)) {
                if (count > 1) {
                    // If the character count is more than 1, decrement it
                    hash[t[i]] = count - 1;
                } else {
                    // If the character count is 1, remove it from the dictionary
                    hash.Remove(t[i]);
                }
            } else {
                // If the character does not exist in the dictionary, return false
                return false;
            }
        }

        // If the dictionary is empty, the strings are anagrams
        return hash.Count == 0;
    }
}
