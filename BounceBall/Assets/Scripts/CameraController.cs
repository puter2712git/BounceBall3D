using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject m_player;

	private float m_xRotateMove;

	public float m_mouseSensitivity = 500.0f;

  void Update(){
		m_xRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * m_mouseSensitivity;

		Vector3 ballPosition = m_player.transform.position;

		transform.LookAt(ballPosition);

		m_player.transform.Rotate(new Vector3(0, m_xRotateMove, 0));
  }
}
