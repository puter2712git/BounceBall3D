using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonEvent : MonoBehaviour {
  public void LoadStageSelectScene() {
    GameManager.Instance.isPlaying = true;
    SceneManager.LoadScene("Stage01-01");
    Debug.Log(GameManager.Instance.isPlaying);
  }
}
