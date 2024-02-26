﻿using Creational.Factory.DesignPattern;

namespace Creational.Factory;

sealed class Program
{
    public static void Main()
    {
        var pierogiWithMeatRestaurant = new PierogiWithMeatRestaurant();
        Console.WriteLine(pierogiWithMeatRestaurant.ServePierogi());
        Console.WriteLine(pierogiWithMeatRestaurant.ServePierogi());
        Console.WriteLine(pierogiWithMeatRestaurant.ServePierogi());
    }
}