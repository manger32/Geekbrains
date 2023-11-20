package ru.gb.lesson1.hw;

import java.util.Arrays;

public class Main {

  public static void main(String[] args) {
    Account account = new CreditAccount(125.0);
    account.take(25.0);
    account.put(1.2);

    System.out.println(account.getAmount()); // 151.2

    System.out.println(account);

    String abcd = "a" + account;
    System.out.println(abcd);

    Integer[] array = {1, 2, 3};
    System.out.println(array);

    String string = Arrays.toString(array);
    System.out.println(string);

  }

}
