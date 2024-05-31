using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    

    [SerializeField]
    private string itemName;

    [SerializeField]
    private string itemType;

    [SerializeField]
    private int quantity;

    [SerializeField]

    private Sprite sprite;

    private InventoryManager inventoryManager;
    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
        Debug.Log("inventoryManager = " + inventoryManager);

    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        
        {
            Debug.Log("collision detected");



             inventoryManager.AddItem(itemName, quantity, sprite, itemType);

            
                gameObject.SetActive(false);
            

        }
    }
}
