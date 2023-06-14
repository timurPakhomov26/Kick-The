using UnityEngine;

public class CoinsPool : MonoBehaviour
{
   [SerializeField] private int _poolCount = 3;
    [SerializeField] private bool _autoExpand = false;
    [SerializeField] private Coin _coinPrefab;

    private PoolMono<Coin> _pool;
    

    private void Start() 
    {
      _pool = new PoolMono<Coin>(_coinPrefab,_poolCount,transform);
      _pool.AutoExpand = _autoExpand;    
    }

    public Coin Create(Vector3 position,Vector3 direction)
    {
       var  bullet = _pool.GetFreeElement();
       bullet.transform.position = position;
      // bullet.GetComponent<Rigidbody2D>().AddForce(direction * bullet.Speed,ForceMode2D.Force);
       return bullet;
    } 
}
