using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BackGroundProvider : MonoBehaviour
{
    [SerializeField] private Image _backGroundImage;
    [SerializeField] private ItemBackGround[] _itemsBackground;
    [SerializeField] private TextMeshProUGUI _coinsValueText;
    [SerializeField] private UiController _uiController;
    [SerializeField] private Init _init;
    private int _previusItemIndex = -1;
    [SerializeField] private int _backGroundIndex = 0;

    private void Start() 
    {
       foreach(var item in _itemsBackground)
      {
        item.IsBuyed = false;    
      }
      _itemsBackground[0].IsBuyed = true;
      
      
    }

    private void Update()
    {
       _coinsValueText.text = _init.playerData.CoinsValue.ToString();
       SetClose();
    }
   /* private void EquipItem()
     {  
        
        _itemsBackground[UiController.WeaponIndex].Close.SetActive(true);

        if(_previusItemIndex != -1)
        {
           _itemsBackground[_previusItemIndex].Close.SetActive(false);
        }

        _previusItemIndex = UiController.WeaponIndex;
     }*/

     private void SetClose()
     {
        foreach (var item in _itemsBackground)
        {
            if(item.IsBuyed == true)
            {
               item.Close.SetActive(false);   
            }
            else
            {
               item.Close.SetActive(true);
            }
        }
     }

    public void SetBackGround(int index)
    {
        _backGroundIndex = index;
       // _backGroundImage.color = _itemsBackground[_backGroundIndex].BackGround.GetComponent<Image>().color;
       if(_itemsBackground[_backGroundIndex].Price <= _init.playerData.CoinsValue && 
                                                             _itemsBackground[_backGroundIndex].IsBuyed == false)
       {
          _itemsBackground[_backGroundIndex].IsBuyed = true;
          _init.playerData.CoinsValue -= _itemsBackground[_backGroundIndex].Price;
          _uiController.ApplyUiElements();
          _coinsValueText.text = _init.playerData.CoinsValue.ToString();
       }
    }

    public void GoToMain()
    {
       ProvidersController.CurrentScene = Scenes.Main;
    }
}
