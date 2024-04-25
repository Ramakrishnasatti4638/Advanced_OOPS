﻿using System;
namespace Overiding;


public class Animal
{
    public virtual void Eat()
    {
        System.Console.WriteLine("Animal eats food");
    }
}

public class Dog:Animal
{
    public override void Eat()
    {
        System.Console.WriteLine("Dog eats food");
        base.Eat();
    }
}

public class Pomerian:Dog
{
    public override void Eat()
    {
        System.Console.WriteLine("Pomerian eats food");
        base.Eat();
    }
}
public class Program 
{
    public static void Main(string[] args)
    {
        Animal animal=new Animal();
        Dog dog=new Dog();
        Pomerian pomerian=new Pomerian();
        animal.Eat();
        dog.Eat();
        pomerian.Eat();
    }
}