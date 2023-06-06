namespace ShapeValidatorService;
public class TriangleShapeValidator
{

    public bool IsValid(double a, double b, double c)
    {
        return (a + b + c == 180);
    }

}
