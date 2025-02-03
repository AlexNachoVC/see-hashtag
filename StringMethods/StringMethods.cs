namespace StringMethods
{
    public class StringMethodsClass
    {
        public static void Explore()
        {
            String fullName = "Alejandro Ignacio";
            String phoneNumber = "123-456-7890";

            fullName = fullName.ToUpper();
            fullName = fullName.ToLower();

            phoneNumber = phoneNumber.Replace('-', '+');

            String userName = fullName.Insert(0, "@");

            int length = fullName.Length;

            string firstName = fullName.Substring(0, 9);

            Console.WriteLine(firstName);
        }
    }
}