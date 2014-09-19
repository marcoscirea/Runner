using UnityEngine;
using System.Collections;

public class BGLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.light.color = new Color(Random.Range(0,1f),Random.Range(0,1f),Random.Range(0,1f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
