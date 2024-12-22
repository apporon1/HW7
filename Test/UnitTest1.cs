using NUnit.Framework;


[TestFixture]
public class ArrayProcessorTests
{
    private ArrayProcessor _processor;

    [SetUp]
    public void Setup()
    {
        _processor = new ArrayProcessor();
    }

    [Test]
    public void ReverseArray_ShouldReturnReversedArray()
    {
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = { 5, 4, 3, 2, 1 };

        int[] result = _processor.ReverseArray(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ReverseArray_ShouldHandleEmptyArray()
    {
        int[] input = { };
        int[] expected = { };

        int[] result = _processor.ReverseArray(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CountEvenNumbers_ShouldReturnCorrectCount()
    {
        int[] input = { 1, 2, 3, 4, 5, 6 };
        int expected = 3;

        int result = _processor.CountEvenNumbers(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CountEvenNumbers_ShouldReturnZero_WhenNoEvenNumbers()
    {
        int[] input = { 1, 3, 5, 7 };
        int expected = 0;

        int result = _processor.CountEvenNumbers(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplyArrayElements_ShouldReturnArrayWithMultipliedValues()
    {
        int[] input = { 1, 2, 3 };
        int multiplier = 2;
        int[] expected = { 2, 4, 6 };

        int[] result = _processor.MultiplyArrayElements(input, multiplier);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplyArrayElements_ShouldHandleZeroMultiplier()
    {
        int[] input = { 1, 2, 3 };
        int multiplier = 0;
        int[] expected = { 0, 0, 0 };

        int[] result = _processor.MultiplyArrayElements(input, multiplier);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplyArrayElements_ShouldThrowException_WhenArrayIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _processor.MultiplyArrayElements(null, 2));
    }
}
