using Stats;

namespace Stat_Test;

public class ArrayStatisticsTests
{
    [Test]
    public void Total_ValidAray_ReturnsCorrectSum()
    {
        //Arrange
        var stats = new ArrayStatistics(new int[] { 1, 2, 3, 4 });
        //Act
        int result = stats.Total();
        //Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void Contains_ElementExists_ReturnTrue()
    {
        var stats = new ArrayStatistics(new int[] { 10, 20, 30 });
        Assert.That(stats.Contains(20), Is.True);
    }
    [Test]
    public void Contains_ElementMissing_ReturnFalse()
    {
        var stats = new ArrayStatistics(new int[] { 10, 20, 30 });
        Assert.That(stats.Contains(50), Is.False);
    }
    [Test]
    public void Sorted_WhenSorted_ReturnsTrue()
    {
        var stats = new ArrayStatistics(new int[] { 1, 5, 10 });
        Assert.That(stats.Sorted(), Is.True );
    }
    [Test]
    public void Sorted_WhenUnsorted_ReturnsTrue()
    {
        var stats = new ArrayStatistics(new int[] { 1, 10, 5 });
        Assert.That(stats.Sorted(), Is.False );
    }
    [Test]
    public void Sort_WhenCalled_ModifiedArrayToSortedOrder()
    {
        //Arrange
        int[] numbers = { 3, 1, 2 };
        var stats = new ArrayStatistics(numbers);
        //Act
        stats.Sort();
        //Assert
        Assert.That(stats.Sorted(), Is.True);
        Assert.That(numbers, Is.EqualTo(new int[]{1,2,3}));
    }
    [Test]
    public void MaxIndex_EmptyArray_ReturnsMinusOne()
    {
        var stats = new ArrayStatistics(new int[] { });
        Assert.That(stats.MaxIndex(), Is.EqualTo(-1));
    }
}