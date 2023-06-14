using UnityEngine;
using TMPro;

public class ItemWeapon : MonoBehaviour
{
   [SerializeField] private int _price;
   public int Price => _price;

   [SerializeField] private TextMeshProUGUI _priceText;
   public TextMeshProUGUI PriceText => _priceText;


   private void Start() 
   {
     _priceText.text = Price.ToString();   
   }
}
