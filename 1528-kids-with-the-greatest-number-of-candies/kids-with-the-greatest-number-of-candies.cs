public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxCandies = candies[0];
        for(int i=0;i<candies.Length;i++){
            if (candies[i]>maxCandies)
                maxCandies = candies[i];
        }
        List<bool> result = new List<bool>();

        for(int i=0;i<candies.Length;i++){
            result.Add(candies[i]+extraCandies>=maxCandies);
        }
        return result;
    }
}