using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Destror : MonoBehaviour {
    
    public GameObject UI_Button;
    public GameObject UI_Button2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ASD()
    {
        UI_Button.SetActive(false); 
    }
    public void SDF()
    {
        UI_Button2.SetActive(false);
    }
}
