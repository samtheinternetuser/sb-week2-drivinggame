using UnityEngine;
public class CameraController : MonoBehaviour

{
	public Transform player;
	public Vector3 cameraOffset;
    public Vector3 FPcameraOffset;
    public Vector3 normalCameraOffset;
    public Vector3 aerialCameraOffset;
	void Start()
	{

	}

	void Update()
	{
	
    if(Input.GetKeyDown(KeyCode.P))
    {
		cameraOffset = FPcameraOffset;

        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    if(Input.GetKeyDown(KeyCode.I))
    {
		cameraOffset = normalCameraOffset;
        transform.rotation = Quaternion.Euler(9, 180, 0);

    }


    if(Input.GetKeyDown(KeyCode.O))
    {
		cameraOffset = aerialCameraOffset;
        transform.rotation = Quaternion.Euler(90, 180, 0);
    }
	}
	
	private void LateUpdate()
	{
		//Method 1, hardcoding the offset
		//transform.position = player.position + new Vector3(0,12,-12);
		
		//Method 2, using a variable for the offset
		transform.position = player.position + cameraOffset;
    }
   
  //  if(Input.GetKeyDown(KeyCode.L))
   // {
 //       cameraOffset = new Vector3(0, 11.5f, -12);
 //   }
    
}