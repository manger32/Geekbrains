package ru.gb.lesson2;

public class NdsCalculator {

  private final NdsResolver ndsResolver;

  public NdsCalculator(NdsResolver ndsResolver) {
    this.ndsResolver = ndsResolver;
  }

  public double withNds(double price) {
    // 20 + (20 * 0.2)
    return price + (price * ndsResolver.ndsForToday());
  }

}
