public class Kata
{
    public static string[] DiagonalsOfSquare(string[] array)
    {
       int nbElement = array.Lenght;
       var ret = new string[nbElement];
       int k;
       
       for(int i = 0; i < nbElement; i++)
       {
         k = i;
         for(int j = 0; j < nbElement; j++)
         {
           ret[i] += array[k][j];
           
           if(k == nbElement-1)
           {
             k = 0;
           }
           else
           {
             k++;
           }
         }
       }
       return ret;
     }
}
