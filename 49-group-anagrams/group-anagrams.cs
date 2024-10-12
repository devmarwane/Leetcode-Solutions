public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {

        Dictionary<string, IList<string>> groups = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] hash = new char[26];
            foreach (char c in strs[i]) {
                hash[c - 'a']++;
            }
            string key = new string(hash);

            if (groups.ContainsKey(key))
                groups[key].Add(strs[i]);
            else
                groups.Add(key, new List<string> { strs[i] });
        }
        return groups.Values.Select(x => x).ToList();
    }
}