using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public float speed = 1;
    public float RotAngleY = 45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rY = Mathf.SmoothStep(0,RotAngleY,Mathf.PingPong(Time.time * speed, 1));
        transform.rotation = Quaternion.Euler(0, rY, 0);   
    }
}
