using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRestart : MonoBehaviour{
	private void Update() {
		if (GameManager.Instance.isPlayerDead) {
			StartCoroutine(RestartScene());
		}
	}

	private IEnumerator RestartScene() {
		yield return new WaitForSeconds(1.5f);
		GameManager.Instance.PlayerDied();
	}
}
