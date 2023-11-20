package classes_5;

import org.junit.Test;

import org.junit.Assert;

public class SummatorTest {
    @Test
    public void testSum() {
        Summator summator = new Summator();
        int actualSum = summator.sum(2, 2);
        int expectedSum = 4;
        Assert.assertEquals(expectedSum, actualSum);
    }
    @Test
    public void testSum2()
    {
        Summator summator = new Summator();
        int actualSum = summator.sum(2, 10);
        int expectedSum = 12;
        Assert.assertEquals(expectedSum, actualSum);
    }
}
