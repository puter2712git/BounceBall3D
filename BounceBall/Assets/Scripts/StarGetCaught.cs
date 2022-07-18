using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGetCaught : MonoBehaviour
{
	private ParticleSystem m_particleSystem;
	private MeshRenderer m_meshRenderer;
	private AudioSource m_audioSource;

	public AudioClip m_starSound;

	private bool isCaught = false;

  void Start() {
		m_particleSystem = GetComponent<ParticleSystem>();
		m_meshRenderer = GetComponent<MeshRenderer>();
		m_audioSource = GetComponent<AudioSource>();
  }

  void Update() {

  }

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Player") && !isCaught) {
			m_particleSystem.Play();
			m_audioSource.PlayOneShot(m_starSound);
			isCaught = true;
			m_meshRenderer.enabled = false;
		}
	}
}
