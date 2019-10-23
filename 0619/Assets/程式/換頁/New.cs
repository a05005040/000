using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New : MonoBehaviour
{ 
public void OnStartGame(string SceneName)
{
    Application.LoadLevel(SceneName);
}

}

