namespace library07
{
    using System.Security;
    [MyAtrribute("I am fluffy)")]
    public class Animal
    {
        private string _country, _name, _feature, _animal;
        public Animal(string animal, string country, string name, string feature)
        {
            _animal = animal;
            _country = country;
            _name = name;
            _feature = feature;
        }
        public string Country { get; set; }
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }
        protected virtual eFavoriteFood GetFavoriteFood()
        {
            return this.GetFavoriteFood();
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Hello! It's me :) ");
        }

        protected virtual eClassificationAnimal GetClassificationAnimal()
        {
            if (this is Cow) return eClassificationAnimal.Herbivores;
            else if (this is Lion) return eClassificationAnimal.Carnivores;
            else if (this is Pig) return eClassificationAnimal.Omnivores;
            else throw new ArgumentException();
        }
    }
    [MyAtrribute("I can give you milk)")]
    public class Cow : Animal
    {
        public Cow(string animal, string country, string name, string feature) : base(animal, country, name, feature)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("Hi! Moo ");
        }
        protected override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.grass;
        }
    }
    [MyAtrribute("I am Simba! )")]
    public class Lion : Animal
    {
        public Lion(string animal, string country, string name, string feature) : base(animal, country, name, feature)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("Hi! Rarrrr ");
        }
        protected override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.meat;
        }
    }
    [MyAtrribute("I am Pumba! )")]
    public class Pig : Animal
    {
        public Pig(string animal, string country, string name, string feature) : base(animal, country, name, feature)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("Hi! Oink ");
        }
        protected override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.vegetables;
        }
    }
    public enum eFavoriteFood { meat, grass, vegetables }
    public enum eClassificationAnimal { Herbivores, Carnivores, Omnivores }
    public class MyAtrribute : Attribute
    {
        public string Comment { get; }
        public MyAtrribute(string comment)
        {
            Comment = comment;
        }
    }
}