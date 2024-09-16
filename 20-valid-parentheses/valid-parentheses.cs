using System.Collections;

public class Solution {
    public bool IsValid(string s)
    {


        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> endToStart = new Dictionary<char, char>();
        endToStart.Add('(', ')');
        endToStart.Add('{', '}');
        endToStart.Add('[', ']');

        foreach (char c in s)
        {
            if (stack.Count != 0)
            {
                char lastChar = stack.Peek();
                if (endToStart.ContainsKey(lastChar) && endToStart[lastChar]==c)
                {
                    stack.Pop();
                    continue;
                }
            }

            stack.Push(c);
        }

        return stack.Count == 0;
    }
}