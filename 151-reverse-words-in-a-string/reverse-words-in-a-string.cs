public class Solution {
    public string ReverseWords(string s) {

        var array = s.Split(new char[] {' ','\t'}, StringSplitOptions.RemoveEmptyEntries);
        int l=0,r=array.Length-1;

        while(l<r){
            if (array[l]==" ")
            {
                array[l]=null;
                l++;
            }
            else if (array[r]==" ")
            {
                array[r]=null;
                r--;
            }
            else{
                var tmp = array[l];
                array[l] = array[r];
                array[r] = tmp;
                l++;
                r--;
            }          

        }

        return string.Join(" ",array ).Trim();



    }
}