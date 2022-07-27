using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarState : MonoBehaviour {
  private Renderer m_starRenderer;
  private MeshCollider m_starMeshCollider;

  private StarCaught starCaught;

  private void Awake() {
    m_starRenderer = GetComponent<Renderer>();
    m_starMeshCollider = GetComponent<MeshCollider>();

    starCaught = GetComponent<StarCaught>();
  }

  private void Update() {
    if (starCaught.isStarCaught) {
      m_starRenderer.enabled = false;
      m_starMeshCollider.enabled = false;
    }
  }
}
