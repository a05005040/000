using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

    public int Index;
    public Text[] Texts;
    //private int 寶石數量, 棒棒糖數量, 吐司數量, 髮圈數量;
    public GameObject UI_backpack;

    private void Start()
    {
        for (int i = 0; i < Texts.Length; i++)
        {
            Texts[i].text = ItemManager.ItemsCount[i].ToString();
        }
    }

    void Update()
    {
        //ItemManager.ItemsCount[0] = PlayerPrefs.GetInt("寶石數量");
        //棒棒糖數量 = PlayerPrefs.GetInt(ItemsCount[1].ToString());
        //吐司數量 = PlayerPrefs.GetInt(ItemsCount[2].ToString());
        //髮圈數量 = PlayerPrefs.GetInt(ItemsCount[3].ToString());

        //Texts[0].GetComponent<Text>().text = ItemManager.ItemsCount[0].ToString();
        //Text_02.GetComponent<Text>().text = ItemsCount[1].ToString();
        //Text_03.GetComponent<Text>().text = ItemsCount[2].ToString();
        //Text_04.GetComponent<Text>().text = ItemsCount[3].ToString();
    }

    public void Cancel()
    {
        
        UI_backpack.SetActive(false);
    }

    public void SetIndex(int index)
    {
        UI_backpack.SetActive(true);

        Index = index;
        UI_backpack.SetActive(false);
        ItemManager.ItemsCount[Index]--;
        Texts[Index].GetComponent<Text>().text = ItemManager.ItemsCount[Index].ToString();
    }
    public void Setopen()
    {
        UI_backpack.SetActive(true);
    }

}
