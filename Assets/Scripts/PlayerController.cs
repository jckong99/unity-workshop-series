using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector3 deltaX = xInput * moveSpeed * Time.deltaTime * transform.right;
        Vector3 deltaY = yInput * moveSpeed * Time.deltaTime * transform.forward;

        rb.MovePosition(rb.position + deltaX + deltaY);
    }
}
