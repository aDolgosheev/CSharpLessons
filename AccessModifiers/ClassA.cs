public class ClassA
{
    public int Prop1 { get; set; }

    private int prop2;
    int Prop2 
    {
        get
        {
            return prop2;
        }
        set
        {
            prop2 = value;
        }
    }

    protected int Prop3 { get; set; }
}
