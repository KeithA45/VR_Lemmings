using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Contains("Lemming")){
            Destroy(collision.gameObject);
        }
    }
}
