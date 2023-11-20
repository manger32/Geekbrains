package ru.gb.lesson1.hw;

public class CreditAccount extends Account {

  public CreditAccount(double amount) {
    super(amount);
  }

  @Override
  public void take(double amount) {
    super.take(amount + amount * 0.01);
  }

}
