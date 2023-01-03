using Structural.Composite.DesignPattern;

sealed class Program
{
    public static void Main()
    {
        var childA = new PierogiChild("Ann");
        var childB = new PierogiChild("Mary");
        var childC = new PierogiChild("Sofia");
        var childD = new PierogiChild("Katherine");

        var momA = new PierogiMom("Lucy");
        var momB = new PierogiMom("Isabel");

        var grandma = new PierogiGrandma("Julia");
        
        momA.AddChild(childA);
        momA.AddChild(childB);
        
        momB.AddChild(childC);
        momB.AddChild(childD);
        
        grandma.AddChild(momA);
        grandma.AddChild(momB);
        
        momA.DisplayChildren();
        momB.DisplayChildren();
        
        grandma.DisplayChildren();
        
        childA.DisplayPierogiProduced();
        childB.DisplayPierogiProduced();
        childC.DisplayPierogiProduced();
        childD.DisplayPierogiProduced();
        
        momA.DisplayPierogiProduced();
        momB.DisplayPierogiProduced();
        
        grandma.DisplayPierogiProduced();
    }
}