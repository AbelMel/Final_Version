using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BulletScript : MonoBehaviour {

	private void Start () 
	{
		
	}

	//using OnCollision from Challenge 5
	private void OnCollisionEnter (Collision collision) 
	{
		if (collision.transform.tag == "Enemy") //if an object with enemy tag
		{
			Destroy(collision.gameObject); //destroys object with tag
		}

		if (collision.transform.tag == "Enemy")  
		{

			KillCounterScript.killCount += 1; //kill counter increases whenever an object is destroyed
			
			collision.transform.gameObject.GetComponent<TargetScript>().isHit = true;

			Destroy(collision.gameObject);
		}
	}
}