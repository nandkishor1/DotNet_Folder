using System;


namespace ExtensionMethodsProject
{
    static class StatClass
    {
        public static void Test3(this Program oProgram ,int i)
        {
            Console.WriteLine("Method 3: " + i);
        }
        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }
        public static string ToProper(this String OldStr)
        {
            if(OldStr.Trim().Length > 0)
            {
                String NewStr = null;
                OldStr = OldStr.ToLower();
                string[] sarr = OldStr.Split(' ');
                foreach(string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if (NewStr == null)
                        NewStr = new string(carr);
                    else

                    NewStr += " " + new string(carr);
                }
                return NewStr;
            }
            return OldStr;
           
        }
    }
}
