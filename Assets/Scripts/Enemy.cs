using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //set Target for Player GameObject to be added
    public GameObject Target;

    //setting the speed of the zombie
    public float speed = 1.6f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //make the zombies follow wherever Target GameObject is located
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //make the zombies look at the Target when following
        transform.LookAt(Target.gameObject.transform);
    }
}
