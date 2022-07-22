using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCaught : MonoBehaviour {
  public bool isStarCaught { private set; get; }

  private void Awake() {
    isStarCaught = false;
  }

  private void OnTriggerEnter(Collider other) {
    if (IsPlayerCollided(other)) {
      isStarCaught = true;
    }
  }

  private bool IsPlayerCollided(Collider other) {
    return other.gameObject.CompareTag("Player");
  }
}
