using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarCaught : MonoBehaviour {
  private Renderer m_starRenderer;
  private Collider m_starCollider;

  private void Awake() {
    m_starRenderer = GetComponent<Renderer>();
    m_starCollider = GetComponent<Collider>();
  }

  private void OnTriggerEnter(Collider other) {
    if (IsPlayerCollided(other)) {
      m_starRenderer.enabled = false;
      m_starCollider.enabled = false;
      GameManager.Instance.eatStarCount++;

      if (GameManager.Instance.eatStarCount == GameManager.Instance.starCountDictionary[SceneManager.GetActiveScene().name]) {
        StartCoroutine(StageClear());
      }
    }
  }

  private bool IsPlayerCollided(Collider other) {
    return other.gameObject.CompareTag("Player");
  }

  private IEnumerator StageClear() {
    GameManager.Instance.EatAllStars();
    yield return new WaitForSeconds(2f);
    GameManager.Instance.StageClear();
  }
}
