using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Catch_minecraft : MonoBehaviour
{
    public AudioClip catch_sound;                           //音效
    public GameObject show_score;                         //動態數量
    public float Y_num = 0.5f;
    private Vector3 Y_pos;
    
    public static int Score_Num;                            //藥水增加數量
    public Text get_minecraft_01;                           //文字顯示藥水
    //private bool state_catch= false;                      //取得狀態                      

    // Use this for initialization
    void Start ()
    {

        get_minecraft_01 = GameObject.Find("數量").GetComponent<Text>();
        PlayerPrefs.GetInt(Score_Num.ToString());
       
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //get_minecraft_01.GetComponent<Text>().text = Score_Num.ToString();
      
        
    }  
    private void OnMouseOver()
    {
       

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //state_catch = true;
            Y_pos.y = Y_num;
            transform.position += new Vector3(0, Y_pos.y, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);

            Get_minecraft();
            Instantiate(show_score, transform.position, transform.rotation);

            GetComponent<AudioSource>().PlayOneShot(catch_sound);
            Destroy(gameObject, 0.3f);
        }
    }
    /// <summary>
    /// 藥水數量顯示
    /// </summary>
    void Get_minecraft()
    {
        //Score_Num += 2;
        //get_minecraft_01.text = Score_Num.ToString();
        Score_Num += 2;
        ItemManager.minecraft_scroce += 2;
        get_minecraft_01.text = Score_Num.ToString();

    }
   
}
