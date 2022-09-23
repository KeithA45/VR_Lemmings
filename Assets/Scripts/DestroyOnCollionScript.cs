using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollionScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Contains("Lemming"))
        {
            Destroy(collider.gameObject);
        }
    }
}
