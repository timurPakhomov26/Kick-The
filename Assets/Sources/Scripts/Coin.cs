using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
   [SerializeField] private Transform _coinsImage;
   public float Speed;

    private void Update() 
    {
        StartCoroutine(Move());
        
    }

    private IEnumerator Move()
    {
       yield return new WaitForSeconds(0.25f);
       transform.position = Vector3.MoveTowards(transform.position,
             _coinsImage.transform.position,25*Time.deltaTime);
    }

   
}
