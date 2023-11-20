package ru.gb.lesson2;

public class AnimalsMain {

  public static void main(String[] args) {
    Cat cat = new Cat("Cat");
    Dog dog = new Dog("Dog");

    HasVoice[] animals = {cat, dog};

    for (HasVoice animal : animals) {
      animal.voice();
    }

    printNameToConsole(cat);
    printNameToConsole(dog);

    Person person = new Person("Igor");
    person.printNameToConsole();
//    printNameToConsole(person);

//    cat.voice();
//    dog.voice();
  }

  static void printNameToConsole(HasName name) {
    System.out.println(name.name());
  }

}
