public static class Prgram
{
    public static void Main(string[] args)
    {
        string word = "hello";
        char[] wordArray = word.ToCharArray();
        int leftIndex = 0;
        int rightIndex = wordArray.Length -1 ;
        
        for (int i = 0; i < wordArray.Length / 2 ; i++ , leftIndex ++ , rightIndex --)
        {
            var temp = wordArray[leftIndex];
            wordArray[leftIndex] = wordArray[rightIndex];
            wordArray[rightIndex] = temp;
        }

        Console.WriteLine(wordArray);
    }    
}


/*
 *    find the maximum number in array and its index
 *     
 *     int[] intArray = { 2, 5, 6, 6, 5 };

        int max = intArray[0];
        int maxIndex = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            if(max <= intArray[i])
            {
                max = intArray[i];
                maxIndex = i;   
            }
        }

        Console.WriteLine($"The max of array is: {max} and the in index is: {maxIndex} ");
 */



/*
   reverse array
  int[] normalArray = { 1,2,3,4,5,6,7,8,9,10 }; //lenght = 10 0 -9
        int[] reverseArray = new int[normalArray.Length];
        int j = 0;
        
        for (int i = normalArray.Length-1; i >= 0; i--, j++)
        {
            reverseArray[j] = normalArray[i];
        }

        for(int i =0; i< reverseArray.Length; i++)
        {
            Console.Write(reverseArray[i]);
        }
     

        int[] normalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0, j = normalArray.Length -1 ; i < (normalArray.Length /2)   ; i++, j--)
        {
            int temp;
            temp = normalArray[i];
            normalArray[i] = normalArray[j];
            normalArray[j] = temp;
        }

        for (int i = 0; i < normalArray.Length; i++)
        {
            Console.Write(normalArray[i]);
        }
 
 */