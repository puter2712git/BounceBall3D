using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Sound : MonoBehaviour {
	public Slider m_audioSlider;

	private void Update() {
		float sound = m_audioSlider.value;
		PlayerPrefs.SetFloat("Sound", sound);
		PlayerPrefs.Save();
	}	
}