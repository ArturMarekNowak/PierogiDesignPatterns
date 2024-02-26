using System.ComponentModel;

namespace Structural.Adapter.Model;

public enum PierogiType
{
    [Description("with potatoes and cheese")]
    WithPotatoesAndCheese,

    [Description("with groat")]
    WithGroat,

    [Description("with cabbage")]
    WithCabbage,

    [Description("with meat")]
    WithMeat,

    [Description("with strawberries")]
    WithStrawberries,

    [Description("with blueberries")]
    WithBlueberries,

    [Description("with potatoes and cheese but also with yoghurt and ketchup")]
    WithPotatoesAndCheeseButAlsoWithYoghurtAndKetchup,
}