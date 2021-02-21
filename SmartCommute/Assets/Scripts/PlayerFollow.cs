using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 cameraoffset;
    [Range(0.01f, 1.0f)]
    public float smoothfactor = 0.5f;
    public bool lookAtPlayer = true;
    public bool RotateAroundPlayer = true;
    public float RotationSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        cameraoffset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
   void LateUpdate()
    {
        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);
            cameraoffset = camTurnAngle * cameraoffset;
        }
        Vector3 newpos = PlayerTransform.position + cameraoffset;
        transform.position = Vector3.Slerp(transform.position, newpos, smoothfactor);
        
        if(lookAtPlayer || RotateAroundPlayer)
        {
            transform.LookAt(PlayerTransform);
        }
    }
}
