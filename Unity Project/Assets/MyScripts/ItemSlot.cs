using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    


    public string itemName;
    public int quantity;
    public Sprite itemSprite;
    public bool isFull;
    public Sprite emptySprite;

    public string itemType;



    


    [SerializeField]

    private TMP_Text quantityText;

    [SerializeField]

    private Image itemImage;


    public GameObject selectedShader;
    public bool thisItemSelected;
    public UiView uiView;


    private InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();

        uiView = FindObjectOfType<UiView>();
    }


    public void AddItem(string itemName, int quantity, Sprite itemSprite, string itemType)
    {

       


        //update NAME
        this.itemName = itemName;

        this.quantity = quantity;


        //update image

        this.itemSprite = itemSprite;


        // update type

        this.itemType = itemType;

        isFull = true;

        quantityText.text = quantity.ToString();
        quantityText.enabled = true;

        itemImage.sprite = itemSprite;

        

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();


        if(eventData.button == PointerEventData.InputButton.Left)
        {
            OnLeftClick();
        }


        if (eventData.button == PointerEventData.InputButton.Right)
        {
            OnRightClick();
        }
    }

    public void OnLeftClick()
    {
        uiView.SetCondition(" ");
        if (thisItemSelected)
        {
            bool usable = inventoryManager.UseItem(itemName);

            if (usable)
            {

                this.quantity -= 1;
                quantityText.text = this.quantity.ToString();

                if (this.quantity <= 0)

                    EmptySlot();

                Debug.Log(itemName + " activated");

            }

            else if (!usable)
            {
                uiView.SetCondition("Item is not usable");

               


            }

            

        }

        else
        {

            inventoryManager.DeselectAllSlots();

            selectedShader.SetActive(true);
            thisItemSelected = true;

        }

        


        Debug.Log(itemName + " selected");
    }

    

    private void EmptySlot()
    {
        quantityText.enabled = false;
        itemImage.sprite = emptySprite;
        
        itemName = "";

        
        itemSprite = emptySprite;

    }

    public void OnRightClick()
    {

    }


}
