package ru.gb.anotherpackage;

public class Student extends Person {

  public Student(String name, int age) { // Igor, 1234
    super(name, age); // new Person("Igor", 1234)
    setName("Student - " + getName());
  }

  public Student() {
    this("Igor", 18);
  }

  // Student() this -> Student(name, age) -> Person(name, age)
  // Student() super -> Person(name, age)

  @Override
  public void setAge(int age) {
    // 18 <= age <= 25
    if (18 <= age && age <= 25) {
      super.setAge(age);
    } else {
      throw new IllegalArgumentException("Неправильный возраст для студента");
    }
  }

}
