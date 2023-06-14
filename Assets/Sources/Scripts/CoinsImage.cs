using UnityEngine;


public class CoinsImage : MonoBehaviour
{
   [SerializeField] private UiController _uiController;
    private void OnTriggerEnter2D(Collider2D other) 
   {
      if(other.GetComponent<Coin>() != null)
      {
         other.gameObject.SetActive(false);
         _uiController.AddCoins();
      }
   }
}
