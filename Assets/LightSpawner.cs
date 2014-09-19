using UnityEngine;
using System.Collections;

public class LightSpawner : MonoBehaviour {
	
	public float chance = 0.0001f;
	public GameObject bgLight;
	ArrayList lights = new ArrayList();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range(0,1f) < chance){
			GameObject tmp = (GameObject) Instantiate(bgLight);
			tmp.transform.position = new Vector2(GameObject.FindGameObjectWithTag("Player").transform.position.x, tmp.transform.position.y + Random.Range(-2f,1f));
			tmp.transform.position += Vector3.right * Random.Range(10,15);
			lights.Add(tmp);
		}
		
		if (lights.Count != 0){
			GameObject check = (GameObject) lights[0];
			if (check.transform.position.x < GameObject.FindGameObjectWithTag("Player").transform.position.x -3){
				lights.RemoveAt(0);
				Destroy(check);
			}
		}
	}

}
