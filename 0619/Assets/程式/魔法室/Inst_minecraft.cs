using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inst_minecraft : MonoBehaviour
{
    public GameObject minecraft;                   //生成的藥水
    public int Sec = 2;
    private Vector3 X_Num,Y_Num;                  //隨機生成

    public Transform[] Points;                     //生成點


    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("Ins_Objs", 0f,Sec);
       
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }
    /// <summary>
    /// 隨機生成位置
    /// </summary>
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
    /// <summary>
    /// 指定生成物件
    /// </summary>
    void Ins_Objs() 

    {
        

        int Random_Points = Random.Range(0, Points.Length);

        //隨機產生0~生成點陣列長度的整數-1(不包含最大值所以-1)。

        Instantiate(minecraft, Points[Random_Points].transform.position, Points[Random_Points].transform.rotation);

        //Instantiate實例化(要生成的物件, 物件位置, 物件旋轉值);

    }


}
