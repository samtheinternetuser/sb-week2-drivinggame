using UnityEngine;

public class bigblob : MonoBehaviour
{
    public float growthrate;
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position += Vector3.back * growthrate * Time.deltaTime;
     //   transform.localScale = transform.localScale * (1f + growthrate * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime);
        //  transform.Translate (Vector3.right * Time.deltaTime);
        //     transform.localScale = transform.localScale * (1.0f + 0.1f * Time.deltaTime);
    }
}
