using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class plaer : MonoBehaviour
{
    public float speed;
    public float rotat;
    public float jump;
    public Rigidbody rb;

    public int score;
    //public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float trans = Input.GetAxis("Vertical") * speed;
        float rot = Input.GetAxis("Horizontal") * rotat;

        rot *= Time.deltaTime;
        trans *= Time.deltaTime;
        transform.Translate(0, 0, trans);
        transform.Rotate(0, rot, 0);

        if (Input.GetButton("Jump"))
        {
            rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
        }


       //if (Input.GetKey(KeyCode.W))
       // {
       //     transform.Translate(Vector3.forward * (Time.deltaTime * speed));
       //     //transform.position += transform.forward * speed * Time.deltaTime;
       // }
        
       // if (Input.GetKey(KeyCode.S))
       // {
       //     transform.Translate(Vector3.back * (Time.deltaTime * speed));
       // }
        
       // if (Input.GetKey(KeyCode.A))
       // {
       //     transform.Rotate(Vector3.left * (Time.deltaTime * rotat));
       // }        
        
       // if (Input.GetKey(KeyCode.D))
       // {
       //     transform.Rotate(Vector3.right * (Time.deltaTime * rotat));
       // }
    }
}
