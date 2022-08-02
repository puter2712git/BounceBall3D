using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButton : MonoBehaviour {
  public void OnClickBack() {
    SceneManager.LoadScene("Main Menu Scene");
  }

  public void OnClickLevel1() {
    GameManager.Instance.isPlaying = true;
    SceneManager.LoadScene("Stage01-01");
  }
}
