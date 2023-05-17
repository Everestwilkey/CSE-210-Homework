public class Account
{
    private int _number;

    public Account (int number)
    {
        SetNumber(number);
    }
    public int GetNumber()
    {
        return _number;
    }
    private void SetNumber(int number)
    {
        if (number <0 )
        {
            throw new ArgumentException("");
        }
        _number =number;
    }
}