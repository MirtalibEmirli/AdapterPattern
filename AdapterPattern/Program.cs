

Tv tv = new();

Device device = new Joiner(tv);
device.TurnOn();

interface Device
{
    public void TurnOn();
}


class Tv() 
{
    public void Join() {
        Console.WriteLine("JOINED");
    }
   
}

//burda ona gore object adaptor isdifade eddimki 
//biz Joiner i Tv den Torede bilmerik menasiz olar
class Joiner : Device
{
    private Tv tv;

    public Joiner(dynamic _tv)
    {
        if(_tv is Tv)
        tv = _tv;
    }

    public void TurnOn()
    {
        tv.Join();
    }
}



