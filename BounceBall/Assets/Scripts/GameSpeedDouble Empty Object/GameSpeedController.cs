using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedController : MonoBehaviour {
  private void Awake() {
    GameManager.Instance.DoubleGameSpeed();
  }
}
