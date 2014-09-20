using UnityEngine;
using System.Collections;

public class ObstacleSound : MonoBehaviour {

	public AudioClip[] audios;
	int selected;
	AudioSource source;

	// Use this for initialization
	void Start () {
		selected = Random.Range(0, audios.Length);
		source = GameObject.FindGameObjectWithTag("Player").audio;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		source.PlayOneShot(audios[selected]);
	}
}
