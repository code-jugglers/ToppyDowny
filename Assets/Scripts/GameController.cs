using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	void Awake () {
		Physics2D.gravity = new Vector2 (0, 0);
	}
}
