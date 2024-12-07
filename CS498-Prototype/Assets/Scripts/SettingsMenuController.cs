using UnityEngine;


public class SettingsMenuController : MonoBehaviour
{
    public GameObject SettingMenu;

    public void ToggleSettingMenu()
    {
        SettingMenu.SetActive(!SettingMenu.activeSelf);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

}