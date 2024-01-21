using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
   
  
    void Update()
    {
        float dirZ = Input.GetAxisRaw("Vertical");
        float dirX = Input.GetAxisRaw("Horizontal");
        float hizOlcusu = 5.0f; 
          if(dirZ !=0 || dirX != 0)
        {
            Vector3 hiz = new Vector3 (dirX*Time.deltaTime*hizOlcusu, 0, dirZ*Time.deltaTime*hizOlcusu);
            transform.Translate(transform.position + hiz);
        }



    }
}

