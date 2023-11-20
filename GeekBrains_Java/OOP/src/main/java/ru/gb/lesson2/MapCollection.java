package ru.gb.lesson2;

import java.util.*;

public class MapCollection {

  public static void main(String[] args) {
    Collection<String> strings = new ArrayList<>();
    strings.add("value");

    Map<String, String> map = new HashMap<>();
//    map.add("value");
    Collection<Map.Entry<String, String>> entries = map.entrySet();

  }

}
