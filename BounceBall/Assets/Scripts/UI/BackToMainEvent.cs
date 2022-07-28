using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainEvent : MonoBehaviour {
	public Canvas m_pauseMenu;

	private void Awake() {
		var obj = FindObjectsOfType<BackToMainEvent>();

		if (obj.Length == 1) {
			DontDestroyOnLoad(gameObject);
		}

		else {
			Destroy(gameObject);
		}
	}

	public void OnBackToMainClick() {
		GameManager.Instance.PauseGame();

		if (m_pauseMenu.gameObject.activeInHierarchy) {
			m_pauseMenu.gameObject.SetActive(false);
		}

		else {
			m_pauseMenu.gameObject.SetActive(true);
		}

		SceneManager.LoadScene("Main Menu Scene");
	}
}
