using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvidersController : MonoBehaviour
{
     public static Scenes CurrentScene;
     [SerializeField] private BackGroundProvider _backGroundMenuScene;
     [SerializeField] private UiController _mainScene;
     [SerializeField] private Bit _bit;
    
    private void Start()
    {
      CurrentScene = Scenes.BackGroundMenu;  
    }

    private void Update() 
    {
      if(CurrentScene == Scenes.BackGroundMenu)
      {
         SetScene(true,false);
      }    
      else
      {
         SetScene(false,true);
      }
    }

    private void SetScene(bool backGroundMenu, bool mainScene)
    {
        _backGroundMenuScene.gameObject.SetActive(backGroundMenu);
        _mainScene.gameObject.SetActive(mainScene);
        _mainScene.enabled = mainScene;
        _bit.enabled = mainScene;
    }

   
}

public enum Scenes
{
   BackGroundMenu,
   Main
}
