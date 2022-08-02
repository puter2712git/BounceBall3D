using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonEvent : MonoBehaviour {
  public void LoadStageSelectScene() {
    SceneManager.LoadScene("Stage Select Scene");
  }
}
