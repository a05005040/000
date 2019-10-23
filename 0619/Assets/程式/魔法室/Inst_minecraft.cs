using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst_minecraft : MonoBehaviour
{
    public GameObject minecraft;                   //藥水
    public int Sec = 2;
    private Vector3 X_Num,Y_Num;                  //隨機生成
    private int i;
    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("SetInterial",0f,Sec);
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void SetInterial()
    {
        X_Num.x = Random.Range(-4, 5);
        Y_Num.y = Random.Range(-4, 5);
        transform.position += new Vector3(X_Num.x, Y_Num.y, 0);
        if (transform.position.x > 1)
        {
            transform.position = new Vector3(1, transform.position.y, 0);
        }
        if (transform.position.x < -2)
        {
            transform.position = new Vector3(-2, transform.position.y, 0);
        }
        if (transform.position.y > 3)
        {
            transform.position = new Vector3(transform.position.x, 3, 0);
        }
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        Instantiate(minecraft, transform.position, transform.rotation);
    }
}
