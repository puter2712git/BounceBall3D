using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBallController : MonoBehaviour
{
  private Rigidbody m_rigidbody;
  private AudioSource m_audioSource;

  private float m_horizontalKey;
  private float m_verticalKey;

	private float m_horizontalSpeed;
	private float m_verticalSpeed;

	private float m_speed = 3f;
  private float m_jump = 8f;

  void Start() {
    Time.timeScale = 2f;

    m_rigidbody = GetComponent<Rigidbody>();
    m_audioSource = GetComponent<AudioSource>();
  }

  void Update() {
    m_horizontalKey = Input.GetAxis("Horizontal");
    m_verticalKey = Input.GetAxis("Vertical");

		m_horizontalSpeed = m_horizontalKey * m_speed;
		m_verticalSpeed = m_verticalKey * m_speed;
  }

  void FixedUpdate() {
		if (m_horizontalKey != 0 || m_verticalKey != 0) {
			Vector3 velocity = new Vector3(m_horizontalSpeed, 0f, m_verticalSpeed);

			m_rigidbody.transform.Translate(velocity * Time.deltaTime);
		}
  }

  private void OnCollisionEnter(Collision other) {
    m_rigidbody.velocity = new Vector3(0, 0, 0);

    Vector3 jumpVelocity = new Vector3(0f, m_jump, 0f);

    if (CheckTypeOfGround(other, "NormalGround") && other.contacts[0].normal.y > 0.7f) {
      m_rigidbody.AddForce(jumpVelocity, ForceMode.Impulse);
    }

    m_audioSource.Play();
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
