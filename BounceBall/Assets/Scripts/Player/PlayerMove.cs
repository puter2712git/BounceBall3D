using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
  PlayerInput playerInput;

  private Rigidbody m_rigidbody;

  private const float m_playerSpeed = 4f;

  private float m_horizontalSpeed;
  private float m_verticalSpeed;

  private void Awake() {
    playerInput = GetComponent<PlayerInput>();
    m_rigidbody = GetComponent<Rigidbody>();
  }

  private void Update() {
    m_horizontalSpeed = playerInput.horizontalAxisMove * m_playerSpeed;
    m_verticalSpeed = playerInput.verticalAxisMove * m_playerSpeed;
  }

  private void FixedUpdate() {
    Move();
  }

  private void Move() {
    Vector3 velocity;

    if ((m_horizontalSpeed != 0 || m_verticalSpeed != 0) && !GameManager.Instance.isPlayerDead) {
      velocity = new Vector3(m_verticalSpeed, 0f, m_horizontalSpeed);
      
      m_rigidbody.transform.Translate(velocity * Time.fixedDeltaTime);
    }
  }
}
