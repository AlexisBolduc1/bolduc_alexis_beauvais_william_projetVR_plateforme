using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class jump : MonoBehaviour
{
    [SerializeField] private InputActionProperty jumpButton;
    public float jumpHeight = 3f;
    [SerializeField] private CharacterController joueur;
    [SerializeField] private LayerMask groundLayer;

    private float gravity = Physics.gravity.y;
    private Vector3 mouvement;

    private void Update()
    {
        bool _isGrounded = isGrounded(); 

        if(jumpButton.action.WasPressedThisFrame()&& _isGrounded)
        {
            Jump();
        }

        mouvement.y += gravity * Time.deltaTime;

        joueur.Move(mouvement * Time.deltaTime);
    }


    public void Jump()
    {
        mouvement.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity); 
    }

    private bool isGrounded()
    {
        return Physics.CheckSphere(transform.position, 0.2f, groundLayer); 
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "espace")
        {
            //Le joueur est plus leger
            jumpHeight = 100f;
        
        }

    }

    private void OnTriggerExit(Collider other){
     if (other.tag == "espace")
        {
            jumpHeight = 20f;
        }

    }


}
