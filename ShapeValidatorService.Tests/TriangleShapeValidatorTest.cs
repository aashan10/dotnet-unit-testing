namespace ShapeValidatorService.Tests;

public class TriangleShapeValidatorTest
{
    [Fact]
    public void TestTriangleShape()
    {
        var triangleShapeValidator = new TriangleShapeValidator();
        Assert.True(triangleShapeValidator.IsValid(60, 60, 60), "Valid triangle shape");

        Assert.False(triangleShapeValidator.IsValid(60, 60, 61), "Invalid triangle shape");

    }
}
