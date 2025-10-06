namespace EdadDao
{
    internal class Program
    {
        public static int pos = 0;
        public static double GetPromedio()
        {
          if (pos > 5) pos = 5;

            double suma = 0, promedio = 0;
            for(int i = 0; i < pos; i++ )
            {
                suma += edades[i];
            }
            promedio = suma / pos;
            return promedio;
        }
    }
}
