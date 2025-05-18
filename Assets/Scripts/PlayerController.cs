using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    //Method 1, using translation for movement

    //  transform.Translate(0,0,speed * Time.deltaTime);

    // method 2 using translation for movement but using short forms

//    transform.Translate(Vector3.forward * speed * Time.deltaTime);
    //method 3, using the physics engine to move our object forward

    rb.AddRelativeForce(Vector3.forward * speed);
    }
}
