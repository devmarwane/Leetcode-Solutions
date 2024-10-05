public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {

        int index=0;
        if (n==0)
            return true;
            
        if (flowerbed.Length == 0)
            return false;

        if (flowerbed.Length==1)
            if (flowerbed[0]==1)
                return false;
            else
                return n==1;

        while(index<flowerbed.Length && n>0){
            if(index==0 && flowerbed[0]==0 && flowerbed[1]==0){
                n--;
                index+=2;
            }
            else if(index==flowerbed.Length-1 && flowerbed[index]==0 && flowerbed[flowerbed.Length-2]==0)
            {
                n--;
                break;
            }
            else if (index-1>=0 && index+1 <flowerbed.Length 
                && flowerbed[index-1]==0
                && flowerbed[index]==0
                && flowerbed[index+1]==0)
            {
                n--;
                index+=2;
            }
            else{
                index++;
            }
        }

        return n==0;
        
    }
}