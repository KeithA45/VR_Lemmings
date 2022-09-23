using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class LemmingMovementV2 : MonoBehaviour
{
    private CharacterController controller;
    public float velocity = 1f;
    public float gravity = 9.8f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementVec = transform.forward * velocity;
        if (!controller.isGrounded)
        {
            movementVec.y -= gravity;
        }

        controller.Move(movementVec * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Contains("Floor")){
            Destroy(this.gameObject);
        }
    }
}

