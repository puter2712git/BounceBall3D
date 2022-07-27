using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XButtonEvent : MonoBehaviour {
  public Button m_soundButton;
  public Canvas m_soundControlCanvas;

  public void ShowSoundButton() {
    m_soundButton.gameObject.SetActive(true);
    m_soundControlCanvas.gameObject.SetActive(false);
  }
}
