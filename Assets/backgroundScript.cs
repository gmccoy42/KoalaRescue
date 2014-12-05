using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class backgroundScript : MonoBehaviour {

	public GameObject rock;
	public GameObject log;
	List<GameObject> obstacles;

	// Use this for initialization
	void Start () {
		obstacles = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnBecameInvisible()
	{
		for(int i = 0; i < obstacles.Count; i++)
		{
			DestroyImmediate(obstacles[i]);
			obstacles.RemoveAt(i);
		}

		transform.Translate(renderer.bounds.size.x * 3, 0, 0);

		int obstacleCount = Random.Range (0, 1);

		obstacleCount = 1;

		for(int i = 0; i < obstacleCount; i++)
		{
			int obs = Random.Range(0, 2);
			if(obs == 0)
			{
				obstacles.Add(Instantiate(rock, new Vector2(this.transform.position.x + 1, -1.498572f), Quaternion.identity) as GameObject);
			}
			else if(obs == 1)
			{
				obstacles.Add(Instantiate(log, new Vector2(this.transform.position.x + 1, -1.498572f), Quaternion.identity) as GameObject);
			}
		}

		
		print("Invisible");
	}
}
