package ru.gb.lesson1.hw;

public class Account {

  private double amount;

  public Account(double amount) {
    this.amount = amount;
  }

  public void put(double amount) {
    this.amount += amount;
  }

  public void take(double amount) {
    this.amount += amount;
  }

  public double getAmount() {
    return amount;
  }

  @Override
  public String toString() {
    return "Account = {" + amount + "}";
  }
}

