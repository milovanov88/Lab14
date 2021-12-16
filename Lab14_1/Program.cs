using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 14");
            string Name;
            Console.WriteLine("Задайте животное кот или собака");
            dataInput(out Name);
            if (Name == "кот")
            {
                Cat cat = new Cat();
                cat.ShowInfo(Name);
            }
            else
            {
                Dog dog = new Dog();
                dog.ShowInfo(Name);
            }
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
        static void dataInput(out string Name)
        {
            try
            {
                Name = Console.ReadLine();
                if (Name.ToLower()!=("кот") && Name.ToLower()!=("собака")) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных. Введите кот или собака заново");
                dataInput(out Name);
            }
        }
    }
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal()
        {
            this.Name = "Животное";
        }
        public abstract string Say();
        public void ShowInfo(string name)
        {

            Console.Write("{0} говорит ", name);
            Console.WriteLine(Say());
        }
    }
    public class Cat : Animal
    {
        public string name = "Кот";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return "Мяу";
        }

    }
    class Dog : Animal
    {
        public string name = "Собака";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return "гав";
        }
    }
}