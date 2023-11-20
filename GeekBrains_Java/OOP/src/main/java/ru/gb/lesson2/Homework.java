package ru.gb.lesson2;

public class Homework {

  /**
   * Модифицируем пример, описанный в предыдущем домашнем задании (со счетами).
   * {@link ru.gb.lesson1.Homework}
   *
   * 1. Класс Account превратить в интерфейс с методами:
   * # double getAmount() - получение текущего баланса
   * # void put(double amount) - пополнить счет
   * # void take(double amount) - снять средства со счета
   *
   * 2. Создать базовый абстрактный класс AbstractAccount, в котором будет общая часть:
   * # поле с балансом
   * # конструктор, который принимает начальное значение баланса
   * # реализация всех методов
   *
   * 3. Добавить еще один класс FixedAmountAccount с особенностью: методы put, take НЕ изменяют баланс.
   *
   * 4.* Класс AbstractAccount можно реализовать хитрее. Пример ниже.
   */

  /**
   * Пример реализации класса AbstractAccount
   */
  public abstract class AbstractAccount /* implements Account */ {

    // поля класса

    // @Override
    public final void take(double amount) {
      if (amount >= 0) {
        doTake(amount);
      } else {
        throw new IllegalArgumentException("Сумма снятия должна быть положительной");
      }
    }

    protected void doTake(double amount) {
//      this.amount -= amount;
    }

  }


}
