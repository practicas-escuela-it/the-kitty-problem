namespace Shared
{
    public class Assert
    {
        public static void NotNull(object item)
        {
            if (item is null)
            {
                throw new System.ArgumentNullException();
            }
        }
    }
}