package ru.gb.lesson4;

import java.util.*;

public class GenericDemo {

  // A <- B <- C <- D <- E

  public static void main(String[] args) {
    List<A> aList = new ArrayList<>();
    List<B> bList = new ArrayList<>();
    List<C> cList = new ArrayList<>();
    List<D> dList = new ArrayList<>();
    List<E> eList = new ArrayList<>();
    List<Object> objectList = new ArrayList<>();

    Comparator<A> aComparator = null;
    Comparator<B> bComparator = null;
    Comparator<C> cComparator = null;
    Comparator<D> dComparator = null;
    Comparator<E> eComparator = null;
    Comparator<Object> objectComparator = null;

    sort(aComparator, aList);
    sort(aComparator, bList);
//    sort(bComparator, aList);
    sort(objectComparator, eList);

//    Collections.sort();

//    foo3(objectList);
//    foo3(aList);
//    foo3(bList);
//    foo3(cList);
//
//    foo4(bList, objectList);

    C c = foo5(cList);
    D d = foo5(dList);
    E e = foo5(eList);

    // Map<C, C> => Map<D, D> -
    // Map<D, D> => Map<C, C> +

    foo6(cList, eList);

  }

  // Метод, который принимает два списка, первый из которых принимает объекты {B, C, D, E},
  // а второй принимает всех дочерних от первого аргумента
  static <T extends B> void foo6(List<T> first, List<? extends T> second) {

  }

  // Метод, который принимает Список мапов и перекладывает их в одну общую мапу Map<?, ?>
  // List<Map<?, ?>>
  static <K, V> void move(List<? extends Map<? extends K, ? extends V>> from, Map<K, V> to) {

  }

  // Метод, который принимает коллекцию типов C D E и возвращает тип этой коллекции
  static <T extends C> T foo5(Collection<T> collection) {
    T next = collection.iterator().next();
    return next;
  }

  // Написать метод, который принимает списки каких-то Comparable-типов
  static <T extends Comparable<T>> void sort(List<T> list) {

  }

  static <T> void sort(Comparator<? super T> comparator, List<? extends T> coll) {
    // comparator = consumer
  }

  // PECS Producer Extends Consumer Super
  // Поставщик Потребитель
  // Метод, который перекачивает данные из одного списка в другой
  static <T extends A> void foo4(List<? extends T> from, List<? super T> to) {

    // List<A> = {A B C D E}
    // List<B> = {  B C D E}
    // A => A +
    // A => B -
    // B => A +
    // C => D -
    // E => C +

    // T = B
    // {B C D E} => {B A Object}

  }

  // Метод, который принимает List с типами C B A Object
  static void foo3(List<? super C> list) {

  }

  // Метод, который принимает 2 списка с типами, содержащие классы C D E
  // Wildcard
  static void foo1(List<? extends C> list1, List<? extends C> list2) {

  }

  // Метод, который принимает 2 списка с типами, содержащие классы C D E
  static <T extends C> void foo2(List<T> list1, List<T> list2) {

  }

  static class A {
    void a() {
    }
  }

  static class B extends A {
    void b() {
    }
  }

  static class C extends B {
    void c() {
    }
  }

  static class D extends C {
    void d() {
    }
  }

  static class E extends D {
    void e() {
    }
  }

}
