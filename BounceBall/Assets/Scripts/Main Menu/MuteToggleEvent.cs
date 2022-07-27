using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggleEvent : MonoBehaviour {
  public void MuteAudio(bool isOn) {
    AudioListener.volume = isOn ? 0 : 1;
  }
}
