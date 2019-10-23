using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Backpack1 : MonoBehaviour {
    public int Index;

    [Header("道具數量陣列")]
    public static int[] ItemsCount = { 10, 10, 10, 10 };
    public Text Text_01, Text_02, Text_03, Text_04;
    private int 寶石數量, 棒棒糖數量, 吐司數量, 髮圈數量;
    public void SetIndex(int index)
    {

       
        Index = index;


    }


    // Use this for initialization
    void Start()
    {
        寶石數量 = PlayerPrefs.GetInt(ItemsCount[0].ToString());
        棒棒糖數量 = PlayerPrefs.GetInt(ItemsCount[1].ToString());
        吐司數量 = PlayerPrefs.GetInt(ItemsCount[2].ToString());
        髮圈數量 = PlayerPrefs.GetInt(ItemsCount[3].ToString());





    }

    // Update is called once per frame
    void Update()
    {

        Text_01.GetComponent<Text>().text = ItemsCount[0].ToString();
        Text_02.GetComponent<Text>().text = ItemsCount[1].ToString();
        Text_03.GetComponent<Text>().text = ItemsCount[2].ToString();
        Text_04.GetComponent<Text>().text = ItemsCount[3].ToString();
    }


    public void put()
    {
        ItemsCount[Index]--;
       
    }
}
