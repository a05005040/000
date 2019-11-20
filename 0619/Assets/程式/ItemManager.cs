using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public int Index;
    public Text Get_minecraft;                           //藥水數量文字
    public static int minecraft_scroce = 1000;           //藥水數量

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

    private void Start()
    {
       
    }

    private void Update()
    {
        Text_01.GetComponent<Text>().text = ItemsCount[0].ToString();
        Text_02.GetComponent<Text>().text = ItemsCount[1].ToString();
        Text_03.GetComponent<Text>().text = ItemsCount[2].ToString();
        Text_04.GetComponent<Text>().text = ItemsCount[3].ToString();

        Get_minecraft.GetComponent<Text>().text = minecraft_scroce.ToString();   //藥水
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


    /// <summary>
    /// 存取魔法藥水顯示
    /// </summary>
    void Set_mineceraft()
    {

        minecraft_scroce = minecraft_scroce + Catch_minecraft.Score_Num;
        Get_minecraft.text = minecraft_scroce.ToString();

    }
}
