namespace WebApp.Models;

public class Calculator
{
    public Operators? Operator { get; set; }
    public double? x { get; set; }
    public double? y { get; set; }
    
    double? result = 0.0d;

    public String Op
    {
        get
        {
            switch (Operator)
            {
                case Operators.Add:
                    result = x + y;
                    break;
                case Operators.Sub:
                    result = x - y;
                    break;
                case Operators.Mul:
                    result = x * y;
                    break;
                case Operators.Div:
                    result = x / y;
                    break;
                default:
                    return "";
            }

            return null;
        }
    }

    public bool IsValid()
    {
        return Operator != null && x != null && y != null;
    }

    public double Calculate() {
        switch (Operator)
        {
            case Operators.Add:
                return (double) (x + y);
                break;
            case Operators.Sub:
                return (double)(x - y);
                break;
            case Operators.Mul:
                return (double)(x * y);
                break;
            case Operators.Div:
                return (double)(x / y);
                break;
            default: return double.NaN;
        }
    }
}
public enum Operators

{
    Add, Sub, Div, Mul
}