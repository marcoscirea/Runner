using UnityEngine;
using System.Collections;

public class ChunkManager : MonoBehaviour
{

    public GameObject chunk;
    int poolN = 5;
    ArrayList pool = new ArrayList();
    Transform player;
    public float changeChance = 0.2f;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Chunk"))
            pool.Add(g);
        //Debug.Log(pool.Count);
    }
    
    // Update is called once per frame
    void Update()
    {
        while (pool.Count < poolN)
        {
            GameObject tmp = (GameObject)Instantiate(chunk);
            GameObject prev = (GameObject)pool [pool.Count - 1];
            tmp.transform.position = prev.transform.position + new Vector3(10f, 0, 0);
            if(Random.Range(0,1f) < changeChance){
                tmp.transform.position = new Vector3(tmp.transform.position.x, Random.Range(-2f,2f), tmp.transform.position.z);
				tmp.transform.position += Vector3.right * Random.Range(0,6f);
            }
            else if (Random.Range(0,1f) < changeChance){
                tmp.transform.position += Vector3.right * Random.Range(0,6f);
            }
            pool.Add(tmp);
        }

        GameObject threshold = (GameObject)pool [1];
        if (player.position.x > threshold.transform.position.x)
        {
            GameObject toDelete = (GameObject)pool [0];
            pool.RemoveAt(0);
            Destroy(toDelete);
        }
    }
}
