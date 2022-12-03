namespace task3
{
    public static class ArrayExtension
    {
        public static int[] CopyArray(this int[])
        {
            int[] arrayCopy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }

            return arrayCopy;
        }
    }
}
