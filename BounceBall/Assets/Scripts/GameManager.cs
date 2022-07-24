using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager {
  private static GameManager instance; // Singleton Variable

  /* 
   * GameManager Property.
   * Can be called by other classes
   */
  public static GameManager Instance {
    get {
      if (instance == null) {
        instance = new GameManager();
      }

      return instance;
    }
  }

  public void DoubleGameSpeed() {
    Time.timeScale = 2f;
  }
}
