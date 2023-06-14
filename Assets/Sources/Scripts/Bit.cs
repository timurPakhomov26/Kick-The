using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bit : MonoBehaviour
{
    public Action OnHitPerson;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _hitForce;
    [SerializeField] private Transform _centreOfMass;
    [SerializeField] private PersonHealth _personHealth;
    public LayerMask _layer;
    
    [SerializeField] private Muscle[] _muscles;

    private void Start() 
    {
       _rigidbody.centerOfMass = _centreOfMass.localPosition;  
    } 

    private void Update() 
    {
       Hit();

       foreach (var muscle in _muscles)
       {
         muscle.ActivateMuscle();
       }
    }

    private void Hit()
    {
      var cursorMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       RaycastHit2D hit = Physics2D.Raycast(cursorMouse,Vector2.zero,100,_layer);
       
      /* if(Input.GetMouseButton(0))
       {
        // RaycastHit2D hit = Physics2D.Raycast(cursorMouse,Vector2.zero,100,_layer);
         if(hit.rigidbody != null)
         {
            hit.transform.position = new Vector3(cursorMouse.x,cursorMouse.y,0);

           // OnHitPerson?.Invoke();
         }
       }*/
       if(Input.GetMouseButtonUp(0))
       {
         //hit.transform.position = transform.position;
         if(hit.rigidbody != null)
         {
            hit.rigidbody.AddForce((new Vector2(hit.transform.position.x,hit.transform.position.y) - hit.point) * _hitForce);
            _personHealth.TakeDamage(1);

            OnHitPerson?.Invoke();
         }
       }  
    }
    
   

   
}

[System.Serializable]
public class Muscle
{
   public Rigidbody2D rigidbody;
   public float restRotation;
   public float force;

   public void ActivateMuscle()
   {
      rigidbody.MoveRotation(Mathf.LerpAngle(rigidbody.rotation,restRotation,force * Time.deltaTime));
   }
}
