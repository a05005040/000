using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Illustration : MonoBehaviour
{
    public int Index;
    public GameObject[] UI_biological;     //生物陣列
  
    // Use this for initialization
    private void Start()
    {
       
    }

   

    // Update is called once per frame
    void Update()
    {

    }
    public void SetIndex(int index)
    {


        Index = index;
        if (Index == 0)
        {
            UI_biological[6].SetActive(true);
            UI_biological[0].SetActive(false);
            UI_biological[1].SetActive(false);
            UI_biological[2].SetActive(false);
            UI_biological[3].SetActive(false);
            UI_biological[4].SetActive(false);
            UI_biological[5].SetActive(false);
        }
        if (Index == 1)
        {
            UI_biological[6].SetActive(false);
            UI_biological[0].SetActive(true);
            UI_biological[1].SetActive(false);
            UI_biological[2].SetActive(false);
            UI_biological[3].SetActive(false);
            UI_biological[4].SetActive(false);
            UI_biological[5].SetActive(false);
        }
        if (Index == 2)
        {
            UI_biological[6].SetActive(false);
            UI_biological[0].SetActive(false);
            UI_biological[1].SetActive(true);
            UI_biological[2].SetActive(false);
            UI_biological[3].SetActive(false);
            UI_biological[4].SetActive(false);
            UI_biological[5].SetActive(false);
        }
        if (Index == 3)
        {
            UI_biological[6].SetActive(false);
            UI_biological[0].SetActive(false);
            UI_biological[1].SetActive(false);
            UI_biological[2].SetActive(false);
            UI_biological[3].SetActive(true);
            UI_biological[4].SetActive(false);
            UI_biological[5].SetActive(false);

        }
        if (Index == 4)
        {

            UI_biological[6].SetActive(false);
            UI_biological[0].SetActive(false);
            UI_biological[1].SetActive(false);
            UI_biological[2].SetActive(true);
            UI_biological[3].SetActive(false);
            UI_biological[4].SetActive(false);
            UI_biological[5].SetActive(false);
        }
        if (Index == 5)
        {
            UI_biological[6].SetActive(false);
            UI_biological[0].SetActive(false);
            UI_biological[1].SetActive(false);
            UI_biological[2].SetActive(false);
            UI_biological[3].SetActive(false);
            UI_biological[4].SetActive(true);
            UI_biological[5].SetActive(false);
        }
    }
   
}
       

