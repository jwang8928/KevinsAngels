using TMPro;
using UnityEngine;

public class OakTabel : MonoBehaviour
{
    public TextMeshProUGUI price;
    public string priceText;
   
    public void ClearPrice()
    {
        price.text = "";
    }
    public void ShowPrice()
    {
        price.text = priceText;
    }
}
