package ru.gb.lesson4;

import java.nio.DoubleBuffer;
import java.util.ArrayList;
import java.util.List;

// T Type
// E element
// S super
// R result
// X exception
// ...
public class Storage<T extends Number> {

  // Класс, который хранит набор чисел какого-то конкретного типа: либо все double, либо все integer, ...
  // Класс должен иметь 2 метода: добавить новое число и посчитать сумму чисел

  private List<T> numbers;

  public Storage() {
    numbers = new ArrayList<>();
  }

  public void add(T x) {
    numbers.add(x);
  }

  public int sum() {
    int sum = 0;
    for (T number : numbers) {
      sum += number.intValue();
    }
    return sum;
  }

}
