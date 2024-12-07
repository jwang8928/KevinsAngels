using UnityEngine;

public class AvatarItems : MonoBehaviour
{
    public bool boughtBlackSlime = false;

    public bool boughtOakTable = false;
    public bool boughtBirchTable = false;
    public bool boughtLeafArt = false;
    public bool boughtCactus = false;
    public bool boughtArmChair = false;
    
    
    
    public static AvatarItems Instance; // Singleton instance


    private void Awake()
    {
        // Ensure only one instance of AvatarItems exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicate instances
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void BuyBlackSlime()
    {
        boughtBlackSlime = true;
    }

    public void BuyOakTable()
    {
        boughtOakTable = true;
    }
    public void BuyBirchTable()
    {
        boughtBirchTable = true;
    }
    public void BuyLeafArt()
    {
        boughtLeafArt = true;
    }

    // Update is called once per frame

}
