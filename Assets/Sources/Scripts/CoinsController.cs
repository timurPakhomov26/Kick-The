using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    [SerializeField] private Bit _bit;
    [SerializeField] private CoinsPool _coinsPool;
    [SerializeField] private Transform _coinSpawn;
    [SerializeField] private Transform _coinsImage;
    private Coin _coin;
    private void OnEnable() 
    {
       _bit.OnHitPerson += CreateCoin;  
    }

    private void OnDisable()
    {
       _bit.OnHitPerson -= CreateCoin;  

    }

    private void CreateCoin()
    {
       _coin = _coinsPool.Create(_coinSpawn.position,new Vector3(0.2f,1,0));
      // StartCoroutine(MoveCoin());
    }

    private IEnumerator MoveCoin()
    {
       yield return new WaitForSeconds(1f);
      _coin.transform.position = Vector3.MoveTowards(_coin.transform.position,
          _coinsImage.transform.position,10*Time.deltaTime);
       
    }
}
