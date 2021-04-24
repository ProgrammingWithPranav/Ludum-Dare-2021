using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;


    void Start()
    {
        
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveAmount = moveInput.normalized * moveSpeed * Time.deltaTime;
        transform.position += (Vector3)moveAmount;
    }
}
