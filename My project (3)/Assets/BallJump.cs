using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    [SerializeField] Material[] materials;
    [SerializeField] int speed;    
    private MeshRenderer mesh;
    private Rigidbody rb;
    private bool changeColor = true;
    private float timer;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (Mathf.Abs(rb.velocity.y) < speed && changeColor == true) 
        { 
            timer = 0;
            changeColor = false;
            ChangeMaterial();
        }
        if(Mathf.Abs(rb.velocity.y) > speed)
        {
            changeColor = true;
        }
        if(changeColor == false)
        {
            Debug.Log(timer);
        }
    }

    private void ChangeMaterial()
    {
        mesh.material = materials[UnityEngine.Random.Range(0, materials.Length)];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            ChangeMaterial();
        }
    }
}
