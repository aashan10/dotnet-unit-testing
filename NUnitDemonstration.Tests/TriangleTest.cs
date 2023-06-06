namespace ShapeValidatorService.Tests;

using NUnitDemonstration;
public class TriangleShapeValidatorTest
{
    [Fact]
    public void TestValidTriangle()
    {
        int firstAngle = 60;
        int secondAngle = 60;
        int thirdAngle = 60;

        string expected = "The triangle is valid.";


        string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestInvalidTriangle()
    {
        int firstAngle = 60;
        int secondAngle = 60;
        int thirdAngle = 61;

        string expected = "The triangle is NOT valid.";

        string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
        Assert.Equal(expected, actual);
    }
}
