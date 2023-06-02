using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector2 direction;
    private float horizontal;
    private float vertical;

    public float MoveSpeed = 3f;


    void Start(){
        
        controller = GetComponent<CharacterController>();     
    }

    void Update(){

        GetInput();
        MovePlayer();
    }


    void GetInput(){

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void MovePlayer(){

        direction = new Vector2(horizontal, vertical).normalized;
        controller.Move(direction * MoveSpeed * Time.deltaTime);
    }

}
