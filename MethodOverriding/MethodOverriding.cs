namespace MethodOverriding
{
    public class MethodOverridingClass
    {
        public static void Explore()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}