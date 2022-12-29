namespace Creational.Builder.DesignPattern;

public class PierogiRestaurant
{
    public void Serve(IPierogiBuilder pierogiBuilder)
    {
        pierogiBuilder.SetPierogiCount();
        pierogiBuilder.SetPierogiType();
    }
}