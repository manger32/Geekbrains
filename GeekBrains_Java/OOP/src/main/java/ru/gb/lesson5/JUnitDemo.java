package ru.gb.lesson5;

import java.util.List;

public class JUnitDemo {

  public <T> void move(List<? extends T> from, List<? super T> to) {
    to.addAll(from);
    from.clear();
  }

  // TDD Test Driven Development
  public String removeSpacesToUpperCase(String text) {
    return text.replaceAll("\\s+", "").toUpperCase();
  }

  /**
   * Если input = null => throws new NullAgeException
   * Если input <= 0 => throws NegativeAgeException
   * Если input > 0, то все ок, ничего не делаем
   */
  public void validateAge(Integer input) {
    if (input == null) {
      throw new NullAgeException();
    } else if (input <= 0) {
      throw new NegativeAgeException();
    }
  }

  public static class NullAgeException extends RuntimeException {

  }

  public static class NegativeAgeException extends RuntimeException {

  }

}
