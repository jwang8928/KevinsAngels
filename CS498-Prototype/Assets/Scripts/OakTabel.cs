using TMPro;
using UnityEngine;

public class OakTabel : MonoBehaviour
{
    public TextMeshProUGUI price;
    public string priceText;
    private TextMeshProUGUI itemName;
    public TextMeshProUGUI UiName;
   
    public void ClearPrice()
    {
        price.text = "";
        UiName.text = "";
    }
    public void ShowPrice()
    {
        name = GetComponentInChildren<TextMeshProUGUI>().text;
        UiName.text = name;
        price.text = priceText;
    }
}
