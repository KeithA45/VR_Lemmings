using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemmingMovement : MonoBehaviour{
   void Start(){}

   void Update()
   {
      transform.Translate(0,-0.001f,-0.001f);
      transform.Translate(0,-0.01f,0);
      transform.Translate(0,0.01f,0);
   }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Floor"){
            Destroy(this.gameObject);
        }
    }
}
