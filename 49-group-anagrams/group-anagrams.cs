public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {

        Dictionary<string, IList<string>> groups = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string key = new String(strs[i].ToCharArray().OrderBy(x => x).ToArray());
            if (groups.ContainsKey(key))
                groups[key].Add(strs[i]);
            else
                groups.Add(key, new List<string> { strs[i] });
        }
        return groups.Values.Select(x => x).ToList();
    }
}