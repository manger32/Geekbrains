package ru.gb.lesson5;

import org.junit.jupiter.api.Test;

class CalculatorTest {

  @Test
  void testSum() {
    Calculator calculator = new Calculator();
    int actualSum = calculator.sum(2, 2); // фактический результат
    int expectedSum = 4; // ожидаемый результат

//    Assertions.assertEquals(expectedSum, actualSum);
    org.junit.jupiter.api.Assertions.assertTrue(expectedSum == actualSum);
  }

  @Test
  void testSum2() {
    Calculator calculator = new Calculator();
    int actualSum = calculator.sum(3, 5); // фактический результат
    int expectedSum = 8; // ожидаемый результат

    org.junit.jupiter.api.Assertions.assertEquals(expectedSum, actualSum);
  }

}