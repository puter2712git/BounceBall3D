using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadzone : MonoBehaviour {
  private void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("Player")) {
      GameManager.Instance.isPlayerDead = true;
    }
  }
}
