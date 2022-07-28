using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButtonClick : MonoBehaviour {
	public Canvas m_pauseMenu;

	private void Awake() {
		var obj = FindObjectsOfType<ResumeButtonClick>();

		m_pauseMenu.gameObject.SetActive(false);

		if (obj.Length == 1) {
			DontDestroyOnLoad(gameObject);
			DontDestroyOnLoad(m_pauseMenu.gameObject);
		}

		else {
			Destroy(gameObject);
		}
	}

	public void OnResumeClick() {
		GameManager.Instance.PauseGame();

		if (m_pauseMenu.gameObject.activeInHierarchy) {
			m_pauseMenu.gameObject.SetActive(false);
		}

		else {
			m_pauseMenu.gameObject.SetActive(true);
		}
	}
}
