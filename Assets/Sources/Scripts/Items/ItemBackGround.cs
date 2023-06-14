using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemBackGround : MonoBehaviour
{
    [SerializeField] private GameObject _close;
    public GameObject Close => _close;

    [SerializeField] private int _price;
    public int Price => _price;

    [SerializeField] private bool _isBuyed;
    public bool IsBuyed => _isBuyed;

    [SerializeField] private TextMeshProUGUI _priceText;

    [SerializeField] private GameObject _backGround;
    public GameObject BackGround => _backGround;

    private void Start() 
    {
      _priceText.text = Price.ToString();    
    }
}
