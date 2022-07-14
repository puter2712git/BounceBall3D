using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGetCaught : MonoBehaviour
{
	private ParticleSystem m_particleSystem;
	private MeshRenderer m_meshRenderer;

	private bool isCaught = false;

  void Start() {
		m_particleSystem = GetComponent<ParticleSystem>();
		m_meshRenderer = GetComponent<MeshRenderer>();
  }

  void Update() {

  }

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Player") && !isCaught) {
			m_particleSystem.Play();
			isCaught = true;
			m_meshRenderer.enabled = false;
		}
	}
}
