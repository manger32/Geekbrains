package ru.gb.lesson4;

import ru.gb.lesson1.hw.Account;
import ru.gb.lesson1.hw.FixedAccount;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Lesson4Main {

  public static void main(String[] args) {


    Storage<Integer> storage = new Storage();
    System.out.println(storage.sum()); // 0

    storage.add(2);
    storage.add(5);
    storage.add(13);
    System.out.println(storage.sum()); // 20


    List<Account> accounts = null;
    List<FixedAccount> fixedAccounts = new ArrayList<>();

    foo(accounts);
    foo(fixedAccounts);
  }

  private static <T extends Account> void foo(List<T> accounts) {

  }

}
