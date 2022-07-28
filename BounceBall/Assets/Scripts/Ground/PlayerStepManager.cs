using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStepManager {
  private static PlayerStepManager instance;

  public static PlayerStepManager Instance {
    get {
      if (instance == null) {
        instance = new PlayerStepManager();
      }

      return instance;
    }
  }

  public bool IsPlayerStepped(Collision other) {
    return (other.gameObject.CompareTag("Player") && other.contacts[0].normal.y == -1.0f);
  }
}
