using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public int Index;

    [Header("道具數量陣列")]
    public static int[] ItemsCount = { 10, 10, 10, 10 };

    [Header("道具提示文字")]
    public string[] ItemsText =
    {
        "棒棒糖", "飽食", "吐司", "髮圈"
    };

    public GameObject UIBuy;
    public Text TextTip;
    public Text Text_01, Text_02, Text_03, Text_04;

    //void Start()
    //{
    //    PlayerPrefs.SetInt("寶石數量", ItemsCount[0]);
    //    PlayerPrefs.SetInt("棒棒糖數量", ItemsCount[1]);
    //    PlayerPrefs.SetInt("吐司數量", ItemsCount[2]);
    //    PlayerPrefs.SetInt("髮圈數量", ItemsCount[3]);
    //}

    private void Update()
    {
        Text_01.GetComponent<Text>().text = ItemsCount[0].ToString();
        Text_02.GetComponent<Text>().text = ItemsCount[1].ToString();
        Text_03.GetComponent<Text>().text = ItemsCount[2].ToString();
        Text_04.GetComponent<Text>().text = ItemsCount[3].ToString();
    }
    public void SetIndex(int index)
    {
        UIBuy.SetActive(true);

        Index = index;

        TextTip.text = ItemsText[Index];
    }

    public void Buy()
    {
        ItemsCount[Index]++;
        UIBuy.SetActive(false);
    }

    public void Cancel()
    {
        UIBuy.SetActive(false);
    }
   
}
