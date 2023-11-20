package ru.gb.lesson3;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Stream;

public class Streams {

  public static void main(String[] args) {
    List<Person> persons = new ArrayList<>();
    persons.add(new Person("Igor", 150));
    persons.add(new Person("Ivan", 20));
    persons.add(new Person("Egor", 25));
    persons.add(new Person("Alexander", 30));

    // Из списка получить только тех сотрудников, кто старше 25 лет.

    List<Person> filtered = persons.stream()
      .filter(it1 -> it1.getAge() > 25)
      .toList();
//      .forEach(it -> System.out.println(it));

    // Всем сотрудникам, старше 25 лет, поднять зарплату на 50
    persons.stream()
      .filter(it -> it.getAge() > 25)
      .forEach(it -> it.setSalary(it.getSalary() + 50.0));

    //

    System.out.println(persons);

    List<String> strings = List.of("Java", "Kotlin", "C#", "C++", "JavaScript", "Go", "Python");
    // Вывести все языки, длина названий которых больше трех в UPPER_CASE, отсортированных по возрастанию длины названия без первой буквы

    strings.stream()
      .filter(it -> it.length() > 3)
      .map(String::toUpperCase)
//      .sorted((a, b) -> a.length() - b.length())
      .sorted(Comparator.comparingInt(String::length).reversed())
      .map(it -> it.substring(1))
      .forEach(System.out::println);

    // filter
    // map
    // forEach
    // limit(5)
    // skip(3)
    // peek
    //

  }

  static class Person {
    private String name;
    private int age;
    private double salary;

    public Person(String name, int age) {
      this.name = name;
      this.age = age;
      this.salary = 100.0;
    }

    public void setSalary(double salary) {
      this.salary = salary;
    }

    public double getSalary() {
      return salary;
    }

    public String getName() {
      return name;
    }

    public int getAge() {
      return age;
    }

    @Override
    public String toString() {
      return "Person{" +
        "name='" + name + '\'' +
        ", age=" + age +
        ", salary=" + salary +
        '}';
    }
  }

}
