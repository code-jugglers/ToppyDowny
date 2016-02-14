using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Level1Manager : LevelManager {
	private List<GameObject> sodas;

	// Use this for initialization
	protected override void Start () {
		base.Start ();
		sodas = new List<GameObject>(GameObject.FindGameObjectsWithTag ("Soda"));
	}
	
	// Update is called once per frame
	protected override void Update () {
		sodas.RemoveAll (soda => !soda.activeSelf);
		if (sodas.Count == 0) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("HomeBase");
		}
		base.Update ();
	}
}
