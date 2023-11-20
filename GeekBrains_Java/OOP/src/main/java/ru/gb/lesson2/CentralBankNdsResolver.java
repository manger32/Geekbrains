package ru.gb.lesson2;

public class CentralBankNdsResolver implements NdsResolver {

  @Override
  public double ndsForToday() {
    return nds();
  }

  public double nds() {
    return 0.2;
  }

}
