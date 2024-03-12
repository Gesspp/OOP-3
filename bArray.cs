namespace Arrays;

internal abstract class bArray : IBaseArray
{
    public bArray(bool fillByUser)
    {
        if (fillByUser)
        {
            userArray();
        }
        else
        {
            randomArray();
        }
    }
    abstract public void Print();
    abstract protected void userArray();
    abstract protected void randomArray();
    abstract public double middle();

}