namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Do()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Do()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Do()
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
	public void Sub_Valid_Do()
	{
        Assert.AreEqual(-1, Program.Subtract("1", "2"));
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
    }

	[TestMethod]
	public void Sub_Invalid_Do()
	{
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

	[TestMethod]
	public void Sub_Null_Do()
	{
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Mult_Valid_Do()
	{
        Assert.AreEqual(2, Program.Multiply("1", "2"));
        Assert.AreEqual(6, Program.Multiply("3", "2"));
        Assert.AreEqual(35, Program.Multiply("5", "7"));
    }

	[TestMethod]
	public void Mult_Invalid_Do()
	{
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Mult_Null_Do()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Div_Valid_Do()
    {
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
        Assert.AreEqual(1.5, Program.Divide("3", "2"));
        Assert.AreEqual(4, Program.Divide("20", "5"));
    }

    [TestMethod]
    public void Div_Invalid_Do()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }

    [TestMethod]
    public void Div_Null_Do()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
}

[TestClass]
public class Power
{
    [TestMethod]
    public void Pow_Valid_Do()
    {
        Assert.AreEqual(1, Program.Power("1", "2"));
        Assert.AreEqual(9, Program.Power("3", "2"));
        Assert.AreEqual(4, Program.Power("2", "2"));
    }

    [TestMethod]
    public void Pow_Invalid_Do()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }

    [TestMethod]
    public void Pow_Null_Do()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}
