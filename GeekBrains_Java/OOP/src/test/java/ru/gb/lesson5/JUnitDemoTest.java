package ru.gb.lesson5;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

class JUnitDemoTest {

  @Test
  void testMove1() {
    JUnitDemo testObject = new JUnitDemo();

    List<Integer> from = new ArrayList<>(Arrays.asList(1, 2, 3));
    List<Integer> to = new ArrayList<>(Arrays.asList(4, 5, 6));

    testObject.move(from, to);

//    Assertions.assertEquals(0, from.size());
    Assertions.assertTrue(from.isEmpty());

    Assertions.assertEquals(6, to.size());
    // 4 5 6 1 2 3
    Assertions.assertEquals(0, to.indexOf(4));
    Assertions.assertEquals(1, to.indexOf(5));
    Assertions.assertEquals(2, to.indexOf(6));
    Assertions.assertEquals(3, to.indexOf(1));
    Assertions.assertEquals(4, to.indexOf(2));
    Assertions.assertEquals(5, to.indexOf(3));
  }

  @Test
  void testRemoveSpacesToUpperCase1() {
    JUnitDemo testObject = new JUnitDemo();

    String data = "abcdDSFDSF wqre asdf asdff      asdfamdfasfasdf";
    String result = testObject.removeSpacesToUpperCase(data);
    Assertions.assertEquals("ABCDDSFDSFWQREASDFASDFFASDFAMDFASFASDF", result);
  }

  @Test
  void testRemoveSpacesToUpperCase2() {
    JUnitDemo testObject = new JUnitDemo();

    String data = "     ";
    String result = testObject.removeSpacesToUpperCase(data);
    Assertions.assertEquals("", result);
  }

  @Test
  void testValidateAgeThrowsNullAgeException() {
    JUnitDemo testObject = new JUnitDemo();
    Assertions.assertThrows(JUnitDemo.NullAgeException.class, () -> testObject.validateAge(null));
  }

  @Test
  void testValidateAgeThrowsNegativeAgeException() {
    JUnitDemo testObject = new JUnitDemo();
    Executable executable = new Executable() {
      @Override
      public void execute() throws Throwable {
        testObject.validateAge(-5);
      }
    };

    Assertions.assertThrows(JUnitDemo.NegativeAgeException.class, () -> testObject.validateAge(-5));
    Assertions.assertThrows(JUnitDemo.NegativeAgeException.class, () -> testObject.validateAge(0));
  }

  @Test
  void testValidateAgeNoException() {
    JUnitDemo testObject = new JUnitDemo();
    Assertions.assertDoesNotThrow(() -> testObject.validateAge(1));
    Assertions.assertDoesNotThrow(() -> testObject.validateAge(10));
  }

}