using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarState : MonoBehaviour {
  private StarCaught starCaught;

  private void Awake() {
    starCaught = GetComponent<StarCaught>();
  }

  private void Update() {
    if (starCaught.isStarCaught) {
      gameObject.SetActive(false);
    }
  }
}
