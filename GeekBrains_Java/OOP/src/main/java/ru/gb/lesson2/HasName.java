package ru.gb.lesson2;

public interface HasName {

  String name();

  default void printNameToConsole() {
    System.out.println(name());
  }

}
