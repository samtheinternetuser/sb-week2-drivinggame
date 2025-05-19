using UnityEngine;

public class blobgrow : MonoBehaviour
{
    public float speed;
    public float growthrate;
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //   transform.localScale = transform.localScale * (1f + growthrate * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
        //     transform.localScale = transform.localScale * (1.0f + 0.1f * Time.deltaTime);
    }
}
