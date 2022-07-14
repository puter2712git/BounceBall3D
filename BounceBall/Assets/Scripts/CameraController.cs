using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject m_player;

	private float m_xRotateMove;

	public float m_mouseSensitivity = 5000000000.0f;

  void Update(){
		m_xRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * m_mouseSensitivity;

		Vector3 ballPosition = m_player.transform.position;

		transform.RotateAround(ballPosition, Vector3.up, m_xRotateMove);

		transform.LookAt(ballPosition);

		m_player.transform.rotation = Quaternion.identity;
  }
}
