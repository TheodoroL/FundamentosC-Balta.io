namespace AulaNameSpace.Calculos;

public class Calculo
{
    private int _x;
    private int _y;

    public Calculo(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public int Soma()
    {
        return _x + _y;
    }
}
