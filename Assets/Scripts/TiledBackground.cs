using UnityEngine;
using System.Collections;

public class TiledBackground : MonoBehaviour {

	private SpriteRenderer spriteRenderer;

	void Awake() {
		spriteRenderer = GetComponent<SpriteRenderer> ();

		Vector2 spriteSize = new Vector2 (spriteRenderer.bounds.size.x / transform.localScale.x, spriteRenderer.bounds.size.y / transform.localScale.y);

		GameObject childPrefab = new GameObject ();
		SpriteRenderer childSprite = childPrefab.AddComponent<SpriteRenderer> ();
		childSprite.transform.position = transform.position;
		childSprite.sprite = spriteRenderer.sprite;

		GameObject child;
		for (int x = 0, w = (int)Mathf.Round (spriteRenderer.bounds.size.x); x < w; x++) {
			for (int y = 0, l = (int)Mathf.Round (spriteRenderer.bounds.size.y); y < l; y++) {
				child = Instantiate (childPrefab) as GameObject;
				child.transform.position = transform.position + (new Vector3 (spriteSize.x * x, -spriteSize.y * y, 0));
				child.transform.parent = transform;
			}
		}

		//childPrefab.transform.parent = transform;

		spriteRenderer.enabled = false;
	}
}
