using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour {
  private GameObject m_player;

  private void Awake() {
    m_player = gameObject.transform.parent.gameObject; // 카메라의 부모 오브젝트인 Bounce Ball 오브젝트를 가져옴
  }

  private void LateUpdate() {
    gameObject.transform.LookAt(m_player.transform.position);
  }
}
