using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour {
	private Renderer m_playerRenderer;
	private Rigidbody m_playerRigidbody;

	private void Awake() {
		m_playerRenderer = GetComponent<Renderer>();
		m_playerRigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate() {
		if (IsPlayerDead()) {
			GameManager.Instance.isPlayerDead = true;
			m_playerRenderer.enabled = false;
			m_playerRigidbody.velocity = Vector3.zero;
			m_playerRigidbody.isKinematic = true;
		}
	}

	private bool IsPlayerDead() {
		return gameObject.transform.position.y < -4 && !GameManager.Instance.isStageCleared;
	}
}