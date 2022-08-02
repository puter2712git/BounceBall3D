using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour {
  private AudioSource m_playerAudioSource;

  public AudioClip m_starCaughtSound;
  public AudioClip m_normalGroundSound;
  public AudioClip m_playerDeadSound;

  private void Awake() {
    m_playerAudioSource = GetComponent<AudioSource>();
  }

  private void OnTriggerEnter(Collider other) {
    if (other.gameObject.name.Equals("Star")) {
      m_playerAudioSource.PlayOneShot(m_starCaughtSound);
    }

    else {
      m_playerAudioSource.PlayOneShot(m_playerDeadSound);
    }
  }

  private void OnCollisionEnter(Collision other) {
    if (IsGroundName(other, "Normal Ground")) {
      m_playerAudioSource.PlayOneShot(m_normalGroundSound);
    }
  }

  private bool IsGroundName(Collision other, string groundName) {
    return (other.gameObject.name.Equals(groundName) && other.contacts[0].normal.y > 0.7f);
  }
}
