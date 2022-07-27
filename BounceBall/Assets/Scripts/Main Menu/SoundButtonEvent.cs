using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonEvent : MonoBehaviour {
  public Button m_soundButton;
  public Canvas m_soundControlCanvas;

  public void ShowSoundSlider() {
    m_soundButton.gameObject.SetActive(false);
    m_soundControlCanvas.gameObject.SetActive(true);
  }
}
