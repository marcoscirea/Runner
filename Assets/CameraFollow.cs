using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    Transform player;
    float distance;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        distance = transform.position.x - player.position.x;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + distance, transform.position.y, transform.position.z);
    }
}
