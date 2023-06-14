using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class UiController : MonoBehaviour
{
    public static int WeaponIndex;
    public static Action OnSetCatalogItem;
    [SerializeField] private Init _init;
    [SerializeField] private Bit _bit;
   // [SerializeField] private ItemCatalog[] _itemsCatalog;
    
    [SerializeField] private TextMeshProUGUI _coinsValueText;  
    [SerializeField] private TextMeshProUGUI _levelValueText;
   

    
   
   private void OnEnable() 
   {
      _bit.OnHitPerson += ApplyUiElements;
   }

   private void OnDisable() 
   {
    
      _bit.OnHitPerson -= ApplyUiElements;
   }

   private void Start() 
   {
      
      ApplyUiElements();
      
   }

   private void Update() 
   {
      
   }

    private void ApplyUiElements()
    {
       _coinsValueText.text = _init.playerData.CoinsValue.ToString();
       _levelValueText.text = _init.playerData.Level.ToString();
    }

    public void AddCoins()
    {
       _init.playerData.CoinsValue ++;
       ApplyUiElements();
    }

    public void SetCatalogItem(int index)
    {
        WeaponIndex = index;
        OnSetCatalogItem?.Invoke();
    }

    public void GoToBackGroundMenu()
    {
      ProvidersController.CurrentScene = Scenes.BackGroundMenu;
    }

 
  
}
