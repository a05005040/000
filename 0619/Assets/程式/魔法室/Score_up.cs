using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_up : MonoBehaviour
{
    public int Up_speed = 3;                      //速度

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0 * Time.deltaTime, Up_speed * Time.deltaTime, 0 * Time.deltaTime);
        Destroy(gameObject,0.5f);
        

    }
}
