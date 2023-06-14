using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatalogProvider : MonoBehaviour
{
  [SerializeField] private ItemCatalog[] _itemsCatalog;
  private int _previusItemIndex = -1;


  private void OnEnable() 
  {
    UiController.OnSetCatalogItem += EquipItem;  
  }
  

   private void OnDisable()
   {
     UiController.OnSetCatalogItem -= EquipItem; 

   } 
   
   private void Start() 
   {
       foreach(var item in _itemsCatalog)
      {
        item.WeaponsAssortment.SetActive(false);
        item.AssortimentBackGround.SetActive(false);
           
      }
      
      EquipItem();
   }


    private void EquipItem()
     {  
        
        _itemsCatalog[UiController.WeaponIndex].WeaponsAssortment.SetActive(true);
        _itemsCatalog[UiController.WeaponIndex].AssortimentBackGround.SetActive(true);

        if(_previusItemIndex != -1)
        {
           _itemsCatalog[_previusItemIndex].WeaponsAssortment.SetActive(false);
           _itemsCatalog[_previusItemIndex].AssortimentBackGround.SetActive(false);
        }

        _previusItemIndex = UiController.WeaponIndex;
     }
}
