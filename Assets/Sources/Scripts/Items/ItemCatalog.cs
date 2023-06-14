using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCatalog : MonoBehaviour
{
    [SerializeField] private GameObject _weaponsAssortment;
    public GameObject WeaponsAssortment => _weaponsAssortment;
    [SerializeField] private GameObject _assortimentBackGround;
    public GameObject AssortimentBackGround => _assortimentBackGround;
    
}
