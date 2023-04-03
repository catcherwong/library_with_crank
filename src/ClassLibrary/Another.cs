namespace ClassLibrary
{
    public class Another
    {
        public static void Method1()
        {
            var b = new byte[10];
            new Random().NextBytes(b);
        }

        public static void Method2()
        {
            var b = new byte[20];
            new Random().NextBytes(b);
        }

        public static void Method3()
        {
            var b = new byte[30];
            new Random().NextBytes(b);
        }
    }
}