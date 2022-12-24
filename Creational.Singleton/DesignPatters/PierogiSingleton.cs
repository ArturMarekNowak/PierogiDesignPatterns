using Creational.Singleton.Interfaces;
using Creational.Singleton.Model;

namespace Creational.Singleton.DesignPatters;

    public sealed class PierogiSingleton : IPierogi
    {
        private static readonly Lazy<PierogiSingleton> LazyInstance = new(() => new PierogiSingleton());

        public static PierogiSingleton Instance => LazyInstance.Value;
        public static bool IsInstanceCreated => LazyInstance.IsValueCreated;
        public int PlatesServed = 0;

        private PierogiSingleton()
        {
        }

        public Pierogi ServePierogiWithPotatoesAndCheese()
        {
            PlatesServed += 1;
            return new Pierogi(Guid.NewGuid(), 10, PierogiTypes.WithPotatoesAndCheese);
        }

        public Pierogi ServePierogiWithGroat()
        {
            PlatesServed += 1;
            return new Pierogi(Guid.NewGuid(), 10, PierogiTypes.WithGroat);
        }

        public Pierogi ServePierogiWithCabbage()
        {
            PlatesServed += 1;
            return new Pierogi(Guid.NewGuid(), 10, PierogiTypes.WithCabbage);
        }

        public Pierogi ServePierogiWithMeat()
        {
            PlatesServed += 1;
            return new Pierogi(Guid.NewGuid(), 10, PierogiTypes.WithMeat);
        }

        public Pierogi ServePierogiWithStrawberries()
        {
            PlatesServed += 1;
            return new Pierogi(Guid.NewGuid(), 10, PierogiTypes.WithStrawberries);
        }

        public Pierogi ServePierogiWithBlueberries()
        {
            PlatesServed += 1;
            return new Pierogi(Guid.NewGuid(), 10, PierogiTypes.WithBlueberries);
        }

        public Pierogi ServePierogiWithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup()
        {
            PlatesServed += 1;
            return new Pierogi(Guid.NewGuid(), 10, PierogiTypes.WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup);
        }
    }