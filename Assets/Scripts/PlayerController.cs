using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed = 20;
    Rigidbody rb;

    float horizontalInput, verticalInput;


    public int playerIndex; //player 1 r 2

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

        //moving left and right

        //recording player inputs

        horizontalInput = Input.GetAxis("Horizontal" + playerIndex); //left and right, a, d,analogue stick left and right
        verticalInput = Input.GetAxis("Vertical" + playerIndex);  //up and down, w,s, analogue stikc up and down

        //move the player left and right

        //transform.Translate(Vector3.right * horizontalInput * turnSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
        // method 2 using translation for movement but using short forms

        //    transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //method 3, using the physics engine to move our object forward

        rb.AddRelativeForce(Vector3.forward * speed * verticalInput);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("blob"))
        {
            SceneManager.LoadScene("gameover");
        }
        else if (other.CompareTag("boat"))
        {
            SceneManager.LoadScene("happyending");
        }
    }

}
