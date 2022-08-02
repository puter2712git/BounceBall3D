using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager {
  private static GameManager instance; // Singleton Variable

  /* 
   * GameManager Property.
   * Can be called by other classes
   */
  public static GameManager Instance {
    get {
      if (instance == null) {
        instance = new GameManager();
      }

      return instance;
    }
  }
  public Dictionary<string, int> starCountDictionary = new Dictionary<string, int>();
  public int eatStarCount = 0;

  public bool isPlaying = false;
  public bool isPlayerDead = false;
  public bool isStageCleared = false;

  public void DoubleGameSpeed() {
    Time.timeScale = 2f;
  }

  public void PauseGame() {
    Time.timeScale = Time.timeScale == 0 ? 2 : 0;
  }

  public void PlayerDied() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    isPlayerDead = false;
    eatStarCount = 0;
  }

  public void EatAllStars() {
    isStageCleared = true;
  }

  public void StageClear() {
    SceneManager.LoadScene("Stage Clear Scene");
  }
}
