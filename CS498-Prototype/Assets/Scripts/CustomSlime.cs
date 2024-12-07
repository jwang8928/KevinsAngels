using UnityEngine;

public class CustomSlime : MonoBehaviour
{

    public GameObject customPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ShowChoices()
    {
        customPanel.SetActive(true);
    }
    public void ClearChoices()
    {
        customPanel.SetActive(false);
    }
}
