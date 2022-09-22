using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemmingMovement : MonoBehaviour{
   public float speed = 1;
   public float RotAngleY = 10;

   void Start(){}

   void Update()
   {
      transform.Translate(0,0,-0.001f);
      transform.Translate(0,-0.01f,0);
      transform.Translate(0,0.01f,0);
   }
}
