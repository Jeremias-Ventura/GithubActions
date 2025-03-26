namespace GithubActionsLab;

[TestClass]
public class Addition
{
    [TestMethod]
    public void Add_Valid_Patino()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }
}

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Subtract("5", "3"));
        Assert.AreEqual(0, Program.Subtract("3", "3"));
        Assert.AreEqual(-4, Program.Subtract("1", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("x", "3"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("3", "y"));
    }

    [TestMethod]
    public void Subtract_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
    }

    [TestMethod]
    public void Multiply_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Divide("4", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
    }

    [TestMethod]
    public void Divide_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("2", null));
    }

    [TestMethod]
    public void Divide_ByZero_Patino()
    {
        Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("2", "0"));
    }
}

[TestClass]
public class Power
{
    [TestMethod]
    public void Power_Valid_Patino()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
    }

    [TestMethod]
    public void Power_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
    }

    [TestMethod]
    public void Power_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
    }
}