package ru.gb.anotherpackage;

public class Person{

  // private   доступен только внутри класса
  // protected доступен внутри пакета + наследники
  // default   доступен внутри пакета
  // public    доступен всем и отовсюду

  private String name;
  private int age;

  public Person() {
    this("Unnamed", 1);
//    this.name = "Unnamed";
//    this.age = 1;
  }

  // имя метода + типы аргументов в определенной последовательности
  public Person(String name, int age) {
    this.name = name;
    setAge(age);
  }

  public void setName(String name) {
    this.name = name;
  }

  public String getName() {
    return name;
  }

  public void setAge(int age) {
    if (age > 0) {
      this.age = age;
    } else {
      throw new IllegalArgumentException("Возраст должен быть положительным");
    }
  }

  public int getAge() {
    return age;
  }
}
