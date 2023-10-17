namespace MedianTests;

public class Tests
{
    private static List<int>? _numList1;
    private static List<int>? _numList2;
    private static List<int>? _numList3;
    private static List<int>? _numList4;
    [SetUp]
    public void Setup()
    {
        _numList1 = new List<int>() { 0, 1, 2, 4, 6, 5, 3 };
        _numList2 = new List<int>() { 4, 8, 6, 2 };
        _numList3 = new List<int>() { 1, 2, 1 };
        _numList4 = new List<int>() { 2, 2, 3, 1 };
    }

    [Test]
    public void FindMedianTest()
    {
        int expected = 3;
        int expected1 = 5;
        int expected2 = 1;
        int expected3 = 2;

        int actual = Program.FindMedian(_numList1!);
        int actual1 = Program.FindMedian(_numList2!);
        int actual2 = Program.FindMedian(_numList3!);
        int actual3 = Program.FindMedian(_numList4!);
        
        Assert.Multiple(() =>
        {
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual1, Is.EqualTo(expected1));
            Assert.That(actual2, Is.EqualTo(expected2));
            Assert.That(actual3, Is.EqualTo(expected3));
        });
    }
}