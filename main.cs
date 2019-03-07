public class Kata
{
    public static bool isSquare(string[] array)
    {
      int nbElement = array.Length;
      for(int i = 0; i < nbElement; i++)
      {
        if(array[i].Length != nbElement)
        {
          return false;
        }
      }
      return true;
    }
    public static string[] DiagonalsOfSquare(string[] array)
    {    
      if(array == null || !isSquare(array))
      {
        return null;
      }
      
       int nbElement = array.Length;
       var ret = new string[nbElement];
       int k;

       for(int i = 0; i < nbElement; i++)
       {
         // ligne de départ
         k = i;
         for(int j = 0; j < nbElement; j++)
         {
           // récuperation de la lettre
           ret[i] += array[k][j];
           
           // si k == 3
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
