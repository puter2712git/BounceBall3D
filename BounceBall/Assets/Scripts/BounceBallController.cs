using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBallController : MonoBehaviour {
  private Rigidbody m_rigidbody;

  private float m_jump = 8f;

  void Start() {
    Time.timeScale = 2f;

    m_rigidbody = GetComponent<Rigidbody>();
  }

  void Update() {
    
  }

  private void OnCollisionEnter(Collision other) {
    m_rigidbody.velocity = new Vector3(0, 0, 0);

    Vector3 jumpVelocity = new Vector3(0f, m_jump, 0f);

    if (CheckTypeOfGround(other, "NormalGround")) {
      m_rigidbody.AddForce(jumpVelocity, ForceMode.Impulse);
    }
  }

  private bool CheckTypeOfGround(Collision other, string tagName) {
    if (other.gameObject.CompareTag(tagName)) {
      return true;
    }
    else {
      return false;
    }
  }
}
