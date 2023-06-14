using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PersonHealth : MonoBehaviour
{

   [SerializeField] private Init _init;
   private float _currentHealthPoint;
   

   [Header("Player Ui")]
   [SerializeField] private TextMeshProUGUI _levelText;
   [SerializeField] private Image _levelView;

   [SerializeField] private int _slowMotionDuration;


   private void Start() 
   {
     _currentHealthPoint = _init.playerData.MaxHealthCount;
     _levelView.fillAmount = _currentHealthPoint;
   }

   public virtual void TakeDamage(float damage)
   {
     _currentHealthPoint -= damage;
     ApplyHealthPoint();
    
    if(_currentHealthPoint <= 0)
    {
      // _currentHealthPoint = 0;
       StartCoroutine(StartSlowMotion());
      
    }    
   }

   private void ApplyHealthPoint()
   {
      _levelView.fillAmount = _currentHealthPoint / _init.playerData.MaxHealthCount;
   }

   private IEnumerator StartSlowMotion()
   {
      Time.timeScale = 0.2f;
      if(_currentHealthPoint < _init.playerData.MaxHealthCount)
      {
        _currentHealthPoint += Time.deltaTime;

      }
      yield return new WaitForSeconds(_slowMotionDuration);
      Time.timeScale = 1f;
   }
}
