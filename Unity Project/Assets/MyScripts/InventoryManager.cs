using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public GameObject InventoryMenu;

    private bool menuActivated;

    public ItemSlot[] itemSlot;

    public ItemSO[] itemSOs;

    private UiView uiView;  
    


    // Start is called before the first frame update
    void Start()
    {
        uiView = FindObjectOfType<UiView>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.I) && menuActivated)

        
        {
            Time.timeScale = 1;
            
            InventoryMenu.SetActive(false); 
            menuActivated = false;
            GameManager.LockMouse();
            uiView.SetCondition(" ");
        }

        else if (Input.GetKeyDown(KeyCode.I) && !menuActivated)


        {

            Time.timeScale = 0;

            InventoryMenu.SetActive(true);
            menuActivated = true;
            GameManager.UnlockMouse();

            

        }


    }

    public bool UseItem(string itemName)
    {

        Debug.Log(itemName + "Imanager before loop");

        Debug.Log(itemSOs.Length);


        for (int i = 0; i < itemSOs.Length; i++)
        
        {
            Debug.Log(itemName + "loop started");
            if (itemSOs[i].itemName == itemName)
            {
                Debug.Log(itemSOs[i].itemName);

                Debug.Log("ItemSO located");

                bool usable = itemSOs[i].UseItem();

                return usable;
            }

            else Debug.Log("ItemSO not located");
        }


        return false;
    }


    public void AddItem(string itemName, int quantity, Sprite itemSprite, string itemType) 
    {
            Debug.Log("itemname = " + itemName +"quantity = " + quantity + "itemSprite = "+  itemSprite + "itemtype = ");

        for (int i = 0; i < itemSlot.Length; i++) 
        
        {
            if (itemSlot[i].isFull == false )
            {
               itemSlot[i].AddItem(itemName, quantity, itemSprite, itemType);
                
                return;
            }
        
        }

        

    }


    public void DeselectAllSlots()
    {
        for (int i = 0; i<itemSlot.Length; i++)
        {
            itemSlot[i].selectedShader.SetActive(false);

            itemSlot[i].thisItemSelected = false;
        }
    }

}
