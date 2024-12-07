using UnityEngine;

public class ItemsInRoom : MonoBehaviour
{
    public GameObject blackSlime;

    // Start is called once before the first frame update
    void Update()
    {
        // Check if the item has been purchased
        if (AvatarItems.Instance != null && AvatarItems.Instance.boughtBlackSlime)
        {
            blackSlime.SetActive(true);
        }
      
    }
}
