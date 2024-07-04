using Xunit;
using Microsoft.AspNetCore.Mvc;
using CalculatorService.Controllers;

public class CalculatorControllerTests
{
    private readonly CalculatorController _controller = new CalculatorController();

    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var result = _controller.Add(1, 2) as OkObjectResult;
        Assert.Equal(3.0, result.Value);
    }

    [Fact]
    public void Subtract_ReturnsCorrectResult()
    {
        var result = _controller.Subtract(5, 3) as OkObjectResult;
        Assert.Equal(2.0, result.Value);
    }

    [Fact]
    public void Multiply_ReturnsCorrectResult()
    {
        var result = _controller.Multiply(3, 4) as OkObjectResult;
        Assert.Equal(12.0, result.Value);
    }

    [Fact]
    public void Divide_ReturnsCorrectResult()
    {
        var result = _controller.Divide(10, 2) as OkObjectResult;
        Assert.Equal(5.0, result.Value);
    }

    [Fact]
    public void Divide_DivisionByZero_ReturnsBadRequest()
    {
        var result = _controller.Divide(10, 0) as BadRequestObjectResult;
        Assert.Equal("Division by zero is not allowed.", result.Value);
    }
}
