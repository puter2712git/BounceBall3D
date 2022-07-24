using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalGround : MonoBehaviour {
  private float normalForce = 8f;

  private void OnCollisionEnter(Collision other) {
    if (PlayerStepManager.Instance.IsPlayerStepped(other)) {
      other.rigidbody.velocity = Vector3.zero;
      
      other.rigidbody.AddForce(normalForce * Vector3.up, ForceMode.Impulse);
    }
  }
}
