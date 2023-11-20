package ru.gb.lesson2;

public abstract class Animal implements HasName, HasVoice {

  private final String name;
  // какая-то базовая, общая для всех животных часть

  public Animal(String name) {
    this.name = name;
  }

  public String getName() {
    return name;
  }

  @Override
  public String name() {
    return getName();
  }

  // абстрактный метод, реализация которого в данный момент неизвестна
  public abstract void voice();

}
