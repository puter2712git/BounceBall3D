using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighJumpGround : MonoBehaviour {
  private float highJumpForce = 12f;

  private void OnCollisionEnter(Collision other) {
    if (PlayerStepManager.Instance.IsPlayerStepped(other)) {
      other.rigidbody.velocity = Vector3.zero;

      other.rigidbody.AddForce(highJumpForce * Vector3.up, ForceMode.Impulse);
    }
  }
}
