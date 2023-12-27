using UnityEngine;
using System.Collections;

class move : MonoBehaviour
{
    public float speed = 10.0f;
    bool jump = false;
    public float jumpforce = 500.0f;
    float inputx;
    float inputy;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start() { }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        inputx = Input.GetAxis("Horizontal");
        inputy = Input.GetAxis("Vertical");
        if (jump)
        {
            Jump();
            jump = false;
        }

    }

    void FixedUpdate()
    {

        rb.velocity = new Vector3(inputx * speed, rb.velocity.y, inputy * speed);
    }

    void Jump()
    {
        rb.AddForce(0, jumpforce, 0);
    }
}