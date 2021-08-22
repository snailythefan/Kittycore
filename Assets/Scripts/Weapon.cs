using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject PuaPrefab;
    public SpriteRenderer playerSprite;

    //we're adding this to add the pukey animation
    public Animator playerAnimator;

    public AudioSource PuaSFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerAnimator.SetTrigger("attack");
        	Shoot();
        }
    }

    void Shoot()
    {
    	//Instantiate(hairballPrefab,Firepoint.position,Firepoint.rotation);
    	if (playerSprite.flipX == true)
    	{
    		Instantiate(PuaPrefab,Firepoint.position,Quaternion.Euler(new Vector3(0,180,0)));
    		PuaSFX.Play();
            Debug.Log("shot!");	
    	}
    	else if (playerSprite.flipX == false)
    	{
    		Instantiate(PuaPrefab,Firepoint.position,Firepoint.rotation);
    		PuaSFX.Play();
            Debug.Log("shot!");	
    	
    	}

    	
    }

   // private void Flip()
    //{
    //	if (playerSprite.flipX == true) //for facing left
    //	{
    		//Firepoint.transform.Rotate(0,180,0);
    //	}

    //	else if (playerSprite.flipX == false) //for facing right
    //	{
    		//Firepoint.transform.Rotate(0,0,0);
    //	}
    //}
}