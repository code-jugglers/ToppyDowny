using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {
	public Text health;
	private PlayerController player;

	protected virtual void Start() {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}

	protected virtual void Update() {
		health.text = "Health: " + player.health;
		if (player.dead) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("GameOver");
		}
	}
}