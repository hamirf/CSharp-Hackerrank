namespace MedianTests;

public class Tests
{
    private static List<int>? _numList1;
    private static List<int>? _numList2;
    [SetUp]
    public void Setup()
    {
        _numList1 = new List<int>() { 0, 1, 2, 4, 6, 5, 3 };
        _numList2 = new List<int>() { 4, 8, 6, 2 };
    }

    [Test]
    public void FindMedianTest()
    {
        int expected = 3;
        int expected1 = 5;

        int actual = Program.FindMedian(_numList1!);
        int actual1 = Program.FindMedian(_numList2!);
        Assert.Multiple(() =>
        {
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual1, Is.EqualTo(expected1));
        });
    }
}