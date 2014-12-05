using UnityEngine;
using System.Collections;

public class KoalaScript : MonoBehaviour {
	public GameObject bird;

	Vector2 newPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		newPos = bird.transform.position;
		this.gameObject.transform.position = (new Vector2(newPos.x, newPos.y + 0.2f));
	}
}
