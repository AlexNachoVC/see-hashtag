namespace TypeCasting
{
    public class TypeCastingClass
    {
        public static void Explore()
        {
            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            int c = 123;
            double d = Convert.ToDouble(c + 0.1);

            Console.WriteLine(d);
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());

            int e = 321;
            String f = Convert.ToString(e);

            Console.WriteLine(e);
            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());


            String g = "$";
            char h = Convert.ToChar(g);

            Console.WriteLine(g);
            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());

            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(i);
            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());

        }
    }
}