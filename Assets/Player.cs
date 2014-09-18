using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public int jump = 50;
    public float speed = 0.1f;
    bool dead = false;
	public int life = 3;
    // Use this for initialization
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!dead){
            //gameObject.rigidbody2D.AddForce(Vector2.right);
            transform.position = transform.position + Vector3.right*speed;
            //Debug.Log(gameObject.rigidbody2D.velocity);   

            if (Input.GetKeyUp(KeyCode.Space) && rigidbody2D.velocity.y ==0)
            {
                rigidbody2D.AddForce(new Vector2(0,1f)*jump);
            }

            if (transform.position.y < -7){
                dead=true;
            }

            transform.rotation = new Quaternion(0,0,0,0);
        }
        else{
            if (Input.GetKeyUp(KeyCode.Space)){
                Application.LoadLevel("Run");
            }
        }
    }

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Obstacle")
			life--;
		if (life <=0)
			dead=true;
	}
}
