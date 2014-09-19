using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {

    public float chance = 0.1f;
    public GameObject obstacle;
    ArrayList obstacles = new ArrayList();
	public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Random.Range(0,1f) < chance){
            GameObject tmp = (GameObject) Instantiate(obstacle);
            tmp.transform.position = new Vector2(GameObject.FindGameObjectWithTag("Player").transform.position.x, tmp.transform.position.y);
            tmp.transform.position += Vector3.right * Random.Range(10,15);
			tmp.rigidbody2D.AddTorque(Random.Range(-5,5));
            obstacles.Add(tmp);
        }

        if (obstacles.Count != 0){
            GameObject check = (GameObject) obstacles[0];
            if (check.transform.position.x < GameObject.FindGameObjectWithTag("Player").transform.position.x -3){
                obstacles.RemoveAt(0);
                Destroy(check);
            }
        }
	}

	public void remove(GameObject go){
		obstacles.Remove(go);
		Instantiate(explosion,go.transform.position, go.transform.rotation);
		Destroy(go);
	}
}
