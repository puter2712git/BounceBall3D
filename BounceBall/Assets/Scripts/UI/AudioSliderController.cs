using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSliderController : MonoBehaviour {
  public AudioMixer m_masterMixer;
  public Slider m_audioSlider;

  private void OnEnable() {
    m_masterMixer.SetFloat("Master", PlayerPrefs.GetFloat("Master"));
    m_audioSlider.value = PlayerPrefs.GetFloat("Master");
    Debug.Log(PlayerPrefs.GetFloat("Master"));
  }

  public void AudioControl() {
    float sound = m_audioSlider.value;

    if (sound == -40f) {
      m_masterMixer.SetFloat("Master", -80f);
      PlayerPrefs.SetFloat("Master", -80f);
    }

    else {
      m_masterMixer.SetFloat("Master", sound);
      PlayerPrefs.SetFloat("Master", sound);
    }
    PlayerPrefs.Save();
  }
}
