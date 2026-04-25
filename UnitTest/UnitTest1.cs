using lab4;
namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void EqualsTest()
    {
        Furniture sofa = new Furniture("Софа", "Тканина", "Вітальня", 3000, 2020);
        Furniture sameSofa = new Furniture("Софа", "Тканина", "Вітальня", 3000, 2020);
        
        bool expected = true;
        bool actual = sameSofa.Equals(sofa);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void ToStingTest()
    {
        Furniture sofa = new Furniture("Софа", "Тканина", "Вітальня", 3000, 2020);
        string expected = "Софа (Тканина, Вітальня) | Ціна: 3000 | Рік: 2020";
            
        Assert.Equal(expected, sofa.ToString());
    }
}