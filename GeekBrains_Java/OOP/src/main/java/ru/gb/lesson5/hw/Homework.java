package ru.gb.lesson5.hw;
import ru.gb.lesson1.hw;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;


public class Homework {
  @Test
  void testMove1() {
    int x = 10;
    Account a = new Account();
    a.put(x);
    Assertions.assertEquals(a.getAmount(), 10);
  }
  @Test
  void testMove2() {
    int x = 10;
    int y = 4;
    Account a = new Account();
    a.put(x);
    a.take(y);
    Assertions.assertEquals(a.getAmount(), x-y);
  }
  @Test
  void testMove3() {
    int x = 10;
    int y = 4;
    CreditAccount a = new CreditAccount();
    a.put(x);
    a.take(y);
    Assertions.assertEquals(a.getAmount(), x-1.01*y);
  }
  @Test
  void testMove4() {
    int x = 10;
    DepositAccount a = new DepositAccount();
    a.put(x);
    Assertions.assertEquals(a.getAmount(), x+1.03*x);
  }
  @Test
  void testMove5() {
    int x = 10;
    int y = 4;
    DepositAccount a = new DepositAccount();
    a.put(x);
    a.take(y);
    Assertions.assertEquals(a.getAmount(), x+1.03*x-y);
  }
  /**
   * Протестировать классы Account, CreditAccount из ДЗ #1.
   *
   * 1. Создать Account. Пополнить его на X рублей. Проверить, что на счету X рублей.
   * 2. Создать Account. Пополнить его на X рублей. Снять с него Y рублей. Проверить, что на счету X-Y рублей.
   * 3. Создать CreditAccount. Пополнить его на X рублей. Снять с него Y рублей. Проверить, что на счету X - 1.01*Y рублей.
   * 4. ** Протестировать DepositAccount. Тест-кейсы придумать самостоятельно. 
   *
   * Примерный код:
   * Account testObject = new Account();
   * testObject.put(10);
   * Assertions.assertEquals(10, testObject.getAmount());
   *
   */

}