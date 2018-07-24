using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour {
	public float speed = 1.0f;
	public float startPosition;
	public float endPosition;

	// Update is called once per frame
	void Update () {
		// Move X position each frams
		transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

		// Check reach to screll end point
		if (transform.position.x <= endPosition) ScrollEnd();
	}

	void ScrollEnd() {
		// Recover as much as scroll distance
		transform.Translate(-1 * (endPosition - startPosition), 0, 0);

		// Send message to other component which is connected same GameObject
		SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
	}
}
