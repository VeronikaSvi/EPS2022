using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D _rb;
    public float jumpForce = 10;
    public float runForce = 5;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) Jump();
        if (Input.GetKeyDown(KeyCode.A)) Run();
    }

    public void Jump()
    {
        _rb.AddForce(new Vector2(0, jumpForce * Time.deltaTime * 1000000));
    }

    public void Run()
    {
        //transform.Translate(new Vector2(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0));
        _rb.AddForce(new Vector2(runForce * Time.deltaTime * 1000000, 0));
    }
}
