package ru.gb.lesson3;

import java.util.Comparator;
import java.util.Set;
import java.util.TreeSet;
import java.util.function.Function;

public class ComparatorComparable {

  public static void main(String[] args) {
    // Comparator, Comparable
    // Iterator, Iterable

//    int x = 3;
//    int y = 5;
//
//    int compare = x.compareTo(y)
//    if (x > y) { // compare > 0
//
//    }

    String java = "abcd";
    String kotlin = "cdba";
    int compare = kotlin.compareTo(java);
    System.out.println(compare);

//    Comparator<String> stringLengthComparator = new Comparator<>() {
//      @Override
//      public int compare(String o1, String o2) {
//        return o2.length() - o1.length();
//      }
//    };

    Comparator<String> stringLengthComparator = (o1, o2) -> o2.length() - o1.length();

    Function<String, Integer> stringIntegerFunction = ComparatorComparable::stringLength;
    Comparator<String> stringLengthComparator2 = Comparator.comparing(stringIntegerFunction);
//       new Function<String, Integer>() {
//      @Override
//      public Integer apply(String s) {
//        return s.length();
//      }
//    });

    stringLengthComparator2.compare("abc", "defg");
    // abc -> 3
    // defg -> 4
    // 3 >= 4


    System.out.println(stringLengthComparator.getClass().getName());

    Set<String> strings = new TreeSet<>(stringLengthComparator);
    strings.add("Java");
    strings.add("Java");
    strings.add("C++");
    strings.add("C");
    strings.add("Kotlin");
    strings.add("C#");
    strings.add("Python");
    System.out.println(strings);

    Set<Person> persons = new TreeSet<>();
    persons.add(new Person(26));
    persons.add(new Person(20));
    persons.add(new Person(100));
    persons.add(new Person(18));
    persons.add(new Person(25));
//    System.out.println(persons);


  }

  static int stringLength(String arg) {
    return arg.length();
  }

  static class StringLengthComparator implements Comparator<String> {

    // (3, 5) -> 2, 3 > 5
    // (5, 3) -> -2 5 < 3

    @Override
    public int compare(String a, String b) {
      // Задача: отсортировать по убыванию длин.

      int aLength = a.length(); // 3
      int bLength = b.length(); // 5

      return bLength - aLength; // 2
    }

  }

  static class Person implements Comparable<Person> {

    private int age;
    private double weight;

    public Person(int age) {
      this.age = age;
    }

    public int getAge() {
      return age;
    }

    @Override
    public int compareTo(Person person) {
      return age - person.getAge();

//      if (age < person.getAge()) {
//        return -1;
//      } else if (age > person.getAge()) {
//        return 1;
//      }
//      return 0;
    }

    @Override
    public String toString() {
      return "(" + age + ")";
    }
  }

}
