using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField]
    private float speed;

    [SerializeField]
    private float accelarationConstant;

    [SerializeField]
    private float maxSpeed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Example1();

        //Example2();

        //Example3();

        //Example4();

        //Example5();
    }

    private void FixedUpdate()
    {
        Example5();
    }

    private void Example1()
    {
        transform.Translate(speed, 0, 0);
    }

    private void Example2()
    {
        rb.MovePosition(rb.position + Vector3.right * speed * Time.deltaTime);
    }

    private void Example3()
    {
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.velocity = movementDirection * speed;
    }

    private void Example4()
    {
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(movementDirection * accelarationConstant);
    }

    private void Example5()
    {
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //rb.AddForce(movementDirection * accelarationConstant);

        if (rb.velocity.magnitude <= maxSpeed)
        {
            rb.AddForce(movementDirection * accelarationConstant);
        }

        Debug.Log(rb.velocity);
    }


}
