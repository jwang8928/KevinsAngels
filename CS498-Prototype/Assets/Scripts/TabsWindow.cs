using UnityEngine;
using UnityEngine.UI;

public class TabsWindow : MonoBehaviour
{
    private Color slimeColor = new Color(56f / 255f, 113f / 255f, 89f / 255f, 1f);
    private Color furnitureColor = new Color(150f / 255f, 99f / 255f, 94f / 255f, 1f);

    public GameObject slimeScreen;
    public GameObject furnitureScreen;
    public GameObject panel; 
    public void SlimeScreen()
    {
        Debug.Log("Pressed");
        slimeScreen.SetActive(true);
        furnitureScreen.SetActive(false);
        panel.GetComponent<Image>().color =slimeColor ;
    }

    public void FurnitureScreen()
    {
        Debug.Log("Pressed");
        slimeScreen.SetActive(false);
        furnitureScreen.SetActive(true);
        panel.GetComponent<Image>().color = furnitureColor;
    }
}
