using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
	private const string m_horizontalAxisName = "Vertical";
	private const string m_verticalAxisName = "Horizontal";
	private const string m_mouseXName = "Mouse X";

	public float horizontalAxisMove { private set; get; }
	public float verticalAxisMove { private set; get; }
	public float mouseXMove { private set; get; }

	private void Update() {
		horizontalAxisMove = Input.GetAxis(m_horizontalAxisName);
		verticalAxisMove = Input.GetAxis(m_verticalAxisName);
		mouseXMove = Input.GetAxis(m_mouseXName);
	}
}
