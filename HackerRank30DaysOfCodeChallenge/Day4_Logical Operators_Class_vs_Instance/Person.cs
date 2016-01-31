namespace Day4_Logical_Operators_Class_vs_Instance
{
    using System;

    public class Person
    {
        private int age;

        public Person(int initial_Age)
        {
            if (initial_Age < 0)
            {
                Console.WriteLine("This person is not valid, setting age to 0.");
            }
            else
            {
                this.Age = initial_Age;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public void amIOld()
        {
            if (this.Age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (this.Age >= 13 && this.Age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            this.Age++;
        }
    }
}