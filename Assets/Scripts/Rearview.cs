using UnityEngine;

public class rearview : MonoBehaviour
{
    public Transform player;
    public Vector3 rvOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
            transform.position = player.position + rvOffset;
    }
}
