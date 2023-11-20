package ru.gb.lesson4;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Homework {

  /**
   * Необходимо создать класс Box, описывающий коробку с фруктами. В одной коробке должны быть фрукты только одного типа.
   * У коробки должны быть методы:
   * 1. Метод добавления нового фрукта в коробку add(Fruit fruit)
   * 2. Метод подсчета суммарного веса коробки getWeight()
   * 3. Метод пересыпания фруктов одной коробки в другую move(Box box)
   * 4. * Реализовать итератор на коробке. То есть должно быть доступно написать foreach, который итерируется по фруктам в коробке.
   */

  public static void main(String[] args) {
    Box<Apple> appleBox = new Box<>();
    System.out.println(appleBox.getWeight()); // 0

    appleBox.add(new Apple(2)); // Должно компилироваться
    appleBox.add(new Apple(4)); // Должно компилироваться
    System.out.println(appleBox.getWeight()); // 6
//    appleBox.add(new Orange(4)); // Не должно компилироваться!!!
    appleBox.add(new GoldenApple(4)); // Должно компилироваться
    System.out.println(appleBox.getWeight()); // 10

    Box<Orange> orangeBox = new Box<>();
//    orangeBox.add(new Apple(2)); // Не должно компилироваться!!!
    orangeBox.add(new Orange(8)); // Должно компилироваться
    System.out.println(orangeBox.getWeight()); // 8

//    orangeBox.move(appleBox); // Не должно компилироваться!!!
//    appleBox.move(orangeBox); // Не должно компилироваться!!!

    Box<GoldenApple> goldenAppleBox = new Box<>();
    goldenAppleBox.add(new GoldenApple(20)); // Должно компилироваться
//    goldenAppleBox.add(new Apple(20)); // Не должно компилироваться!!!

//    appleBox.move(goldenAppleBox); // Не должно компилироваться!!!
    goldenAppleBox.move(appleBox); // Должно компилироваться

    System.out.println(goldenAppleBox.getWeight()); // 0
    System.out.println(appleBox.getWeight()); // 30

    for (Apple apple: appleBox) { // Должно компилироваться

    }

    for (GoldenApple goldenApple: goldenAppleBox) { // Должно компилироваться

    }

    for (Orange orange: orangeBox) { // Должно компилироваться

    }

  }

  static class Box<T extends Fruit> implements Iterable<T> {

    private final List<T> storage = new ArrayList<>();

    public void add(T fruit) {
      storage.add(fruit);
    }

    public int getWeight() {
      return storage.stream()
        .mapToInt(Fruit::getWeight)
        .sum();

//      int sum = 0;
//      for (T fruit : storage) {
//        sum += fruit.getWeight();
//      }
//      return sum;
    }

    // PECS Producer - Extends, Consumer - Super
    public void move(Box<? super T> another) { // FIXME Должен быть дженерик!
      storage.forEach(another::add);
      storage.clear();

//      Iterator<T> iterator = storage.iterator();
//      while (iterator.hasNext()) {
//        T fruit = iterator.next();
//        another.add(fruit);
//        iterator.remove();
//      }

//      for (T fruit : storage) {
//        another.add(fruit);
//      }
//      storage.clear();
    }

    @Override
    public Iterator<T> iterator() {
      return storage.iterator();
    }
  }

  static class Fruit {

    private int weight;

    public Fruit(int weight) {
      this.weight = weight;
    }

    public int getWeight() {
      return weight;
    }
  }

  static class Apple extends Fruit {
    public Apple(int weight) {
      super(weight);
    }
  }

  static class GoldenApple extends Apple {
    public GoldenApple(int weight) {
      super(weight);
    }
  }

  static class Orange extends Fruit {
    public Orange(int weight) {
      super(weight);
    }
  }

}
