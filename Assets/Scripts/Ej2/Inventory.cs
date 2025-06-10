using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int itemCount = 0;

    public void AddItem()
    {
        itemCount++;
        Debug.Log("Objeto recolectado. Total: " + itemCount);
    }
}