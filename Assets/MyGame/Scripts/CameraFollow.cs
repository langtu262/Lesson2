 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.5f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = target.position+offset;
        Vector3 smothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smothPosition;
        transform.LookAt(target.position);
    }
}*/
public class CameraFollow : MonoBehaviour
{
    private Transform player;
    public float distance = 6;
    public float height = 5f;
    public float shouderOffset = 0;
    public bool switchSoulder=false;
    public float smoonthtime = 0.25f;
    private Vector3 lookTarget;
    private Vector3 lookTargetVelocity;
    private Vector3 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
       Vector3 target = player.position - player.transform.forward * distance;
        Vector3 verticalPosition = Vector3.up * height;
        Vector3 shouderPosition = switchSoulder ? transform.right * -shouderOffset : transform.right * shouderOffset;
        transform.position = Vector3.SmoothDamp(transform.position, target + verticalPosition + shouderPosition, ref currentVelocity, smoonthtime);
        lookTarget = Vector3.SmoothDamp(lookTarget, player.position + verticalPosition + shouderPosition, ref lookTargetVelocity, smoonthtime);
        transform.LookAt(lookTarget);
    }
}
