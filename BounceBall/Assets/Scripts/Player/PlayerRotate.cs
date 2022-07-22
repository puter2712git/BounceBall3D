using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour {
  PlayerInput playerInput;

  public float m_mouseSensitivity = 50f;

  private float m_xRotateSpeed;

  private void Awake() {
    playerInput = GetComponent<PlayerInput>();
  }

  private void Update() {
    Rotate();
  }

  private void Rotate() {
    m_xRotateSpeed = playerInput.mouseXMove * m_mouseSensitivity * Time.deltaTime;

    gameObject.transform.Rotate(new Vector3(0f, m_xRotateSpeed, 0f));
  }
}
