using System.ComponentModel;

namespace Creational.AbstractFactory.Model;

public enum MeatType
{
    [Description("pork")]
    Pork,

    [Description("beef")]
    Beef,

    [Description("lamb")]
    Lamb,
}