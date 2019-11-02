using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch_minecraft : MonoBehaviour
{
    public AudioClip catch_sound;                           //音效
    public GameObject show_score;                         //動態數量
    public float Y_num = 0.5f;
    private Vector3 Y_pos;
    //private bool state_catch= false;                      //取得狀態                      

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Score_time.Score_Num);

    }  
    private void OnMouseOver()
    {
       

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //state_catch = true;
            Y_pos.y = Y_num;
            transform.position += new Vector3(0, Y_pos.y, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);

            Score_time.Score_Num += 2;
            Instantiate(show_score, transform.position, transform.rotation);

            GetComponent<AudioSource>().PlayOneShot(catch_sound);
            Destroy(gameObject, 0.3f);
        }
    }
}
