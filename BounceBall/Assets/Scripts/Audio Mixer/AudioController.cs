using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour {
  public AudioMixer m_masterMixer;
  public Slider m_audioSlider;

  public void AudioControl(float sliderVal) {
    m_masterMixer.SetFloat("Master Volume", Mathf.Log10(sliderVal) * 20);
  }

  public void ToggleAudioVolume() {
    AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
  }
}
