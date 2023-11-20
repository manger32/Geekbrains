package ru.gb.lesson2;

public class Lesson2Main {

  public static void main(String[] args) {
    // Интерфейс, контракт, API -

    // Абстрактные класс
    // Класс, экземпляр которого нельзя создать
    // Это базовый класс, который нужен, чтобы создавать наследуемые классы

    // Интерфейс
    // Некий контракт, который описывает что должен делать класс, но не описывает, как

    // Концептуальные отличия:
    // 1. Абстрактный класс - это класс, в котором есть поля, конструкторы, методы с реализациями
    // 2. Наследоваться можно от одного класса, имплементировать сколько угодоно интерфейсов

    // JDBC Java Database Connectivity
  }

  static class MyClass extends A1 implements I1, I2, I3 {

  }

  static abstract class A1 {

  }

  static abstract class A2 {

  }

  interface I1 {

  }

  interface I2 {

  }

  interface I3 {

  }

}
