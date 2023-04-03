namespace ClassLibrary
{
    public static class Utils
    {
        public static string DoSomething(string str, int len)
        {
            // For showing benchmark and pull request
            var b = new byte[20];

            if (str.Length > len)
            {
                return str.Substring(0, len) + "...";
            }
            else
            {
                return str;
            }
        }

        public static string GetSomething(string str)
        {
            if (str.Length > 10)
            {
                return "123";
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10);
                }

                return "123";
            }
        }
    }
}