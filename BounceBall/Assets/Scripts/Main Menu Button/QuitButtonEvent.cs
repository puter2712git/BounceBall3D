using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonEvent : MonoBehaviour {
  public void QuitGame() {
    #if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
    #else
    Application.Quit();
    #endif
  }
}
