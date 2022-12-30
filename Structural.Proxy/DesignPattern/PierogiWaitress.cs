using System.Net.Http.Headers;
using Structural.Proxy.Interfaces;
using Structural.Proxy.Model;

namespace Structural.Proxy.DesignPattern;

public class PierogiWaitress : IPierogiService
{
    private readonly PierogiKitchen _pierogiKitchen = new();
    private int _clientsAge = 0;

    public void SetClientsAge(int age)
    {
        _clientsAge = age;
    }
    
    private void AssertClientIsAdult()
    {
        if (_clientsAge < 18) throw new Exception("You are not adult you can't eat pierogi :c");
        
        Console.WriteLine("You are adult you can eat pierogi :D");
    }
    
    public Pierogi ServePierogiWithPotatoesAndCheese()
    {
        AssertClientIsAdult();
        return _pierogiKitchen.ServePierogiWithPotatoesAndCheese();
    }

    public Pierogi ServePierogiWithGroat()
    {
       AssertClientIsAdult();
        return _pierogiKitchen.ServePierogiWithGroat();
    }

    public Pierogi ServePierogiWithCabbage()
    {
        AssertClientIsAdult();
        return _pierogiKitchen.ServePierogiWithCabbage();
    }

    public Pierogi ServePierogiWithMeat()
    {
        AssertClientIsAdult();
        return _pierogiKitchen.ServePierogiWithMeat();
    }

    public Pierogi ServePierogiWithStrawberries()
    {
        AssertClientIsAdult();
        return _pierogiKitchen.ServePierogiWithStrawberries();
    }

    public Pierogi ServePierogiWithBlueberries()
    {
        AssertClientIsAdult();
        return _pierogiKitchen.ServePierogiWithBlueberries();
    }

    public Pierogi ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup()
    {
        AssertClientIsAdult();
        return _pierogiKitchen.ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup();
    }
}