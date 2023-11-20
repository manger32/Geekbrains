package ru.gb.lesson1;

import ru.gb.anotherpackage.Person;
import ru.gb.anotherpackage.Student;

public class Lesson1Main {

  public static void main(String[] args) {
    // 1. Инкапсуляция
    Person person = new Person("Igor", 250);
    printPersonInfo(person);

//    String personName = person.getName();
//    System.out.println(personName);
//
//    // 2. Наследование
//    Person defaultPerson = new Person();
//    System.out.println(defaultPerson.getName());
//    System.out.println(defaultPerson.getAge());
//
    Person defaultStudent = new Student();
    System.out.println(defaultStudent.getName()); // Student
    System.out.println(defaultStudent.getAge()); // 18

    // 3. Полиморфизм

    // Person <- Student
    printPersonInfo(defaultStudent);
  }

  static void printPersonInfo(Person person) {
    System.out.println(person.getName() + " - " + person.getAge());
  }

  // A
  // B1 extends A, B2 extends A
  // C1 extends B2

}
