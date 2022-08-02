using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageStarCount : MonoBehaviour {
  private int m_starCount;

	private void Awake() {
    m_starCount = this.transform.childCount;
    
    if (GameManager.Instance.starCountDictionary.ContainsKey(SceneManager.GetActiveScene().name) == true) {
      GameManager.Instance.starCountDictionary.Remove(SceneManager.GetActiveScene().name);
    }
    GameManager.Instance.starCountDictionary.Add(SceneManager.GetActiveScene().name, m_starCount);
  }
}
