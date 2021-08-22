using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pua : MonoBehaviour
{
	public float speed = 20f;
    public Rigidbody2D rb;
  
    // Start is called before the first frame update
    void Start()
    {
    	rb.velocity = transform.right * speed;
    }



    void OnTriggerEnter2D (Collider2D other)
    //this is so the bullets ignore the collider of gameObjects tagged as "Player", and thus they won't destroy
    //themselves immediately on Click
    {
    	if (other.gameObject.tag != "Player")
    	{
    		Enemy enemy = other.GetComponent<Enemy>();

    		if(enemy != null)
    		{
    			enemy.TakeDamage(30);
    		}

    		Destroy(gameObject);
    		Debug.Log("destroyed!");
    	}
    	
    } 

    
}
