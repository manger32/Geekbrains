package ru.gb.lesson3;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class LocalDateExample {

  private double amount;
  private LocalDate lastWithdraw;

  public LocalDateExample(double amount) {
    this.amount = amount;
    lastWithdraw = LocalDate.now();
  }

  // [lastWithdraw, ..., now, lastWithdraw + 1month]
  public void take(double amount) {
    if (amount >= 0) {
      LocalDate now = LocalDate.now();
      if (!lastWithdraw.plus(1, ChronoUnit.MONTHS).isBefore(now)) {
        this.amount -= amount;
        lastWithdraw = now;
      }
    }
  }

}
