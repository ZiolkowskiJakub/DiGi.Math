namespace DiGi.Math
{
    public static partial class Query
    {
        public static double MatrixCofactor(int row, int column)
        {
            if ((row + column) % 2 == 1)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}