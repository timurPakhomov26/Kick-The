using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    private void Awake() 
    {
       Application.targetFrameRate = 35;    
    }
}
