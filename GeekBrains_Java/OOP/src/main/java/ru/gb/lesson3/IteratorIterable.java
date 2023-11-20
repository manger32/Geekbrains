package ru.gb.lesson3;

import java.util.Iterator;
import java.util.List;

public class IteratorIterable {

  public static void main(String[] args) {
    // Iterable<T> iterable -> Iterator<T> iterator = iterable.iterator();

    Iterator<String> iterator = null; // неважно

    Iterable<String> iterable = () -> iterator;

    Iterator<String> iterator1 = iterable.iterator();


    List<Integer> ints = List.of(1, 2, 3, 4, 5);

    Iterator<Integer> intsIterator = ints.iterator();
    System.out.println(intsIterator.next());
    System.out.println(intsIterator.next());
    System.out.println(intsIterator.next());
    System.out.println(intsIterator.next());
    System.out.println(intsIterator.next());
    System.out.println(intsIterator.next());

    for (Integer x : ints) {
      System.out.println(x);
    }

//    Iterator<Integer> iterator = ints.iterator();
//    while (iterator.hasNext()) {
//      Integer item = iterator.next();
//      System.out.println(item);
//    }


//    TelegramAccount account = new TelegramAccount();
//    for (TelegramChat chat: account) {
//
//    }
//
//    Iterator<TelegramChat> chatIterator = account.iterator();
//    while (chatIterator.hasNext()) {
//      TelegramChat chat = chatIterator.next();
//    }

  }

//  static class TelegramAccount implements Iterable<TelegramChat> {
//
//    private TelegramChat[] chats;
//
//    @Override
//    public Iterator<TelegramChat> iterator() {
//
//    }
//
//  }
//
//  static class TelegramChat {
//
//  }

}
