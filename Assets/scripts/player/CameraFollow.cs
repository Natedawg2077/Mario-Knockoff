using UnityEngine;
//satij
//march 17th 
//Code to make camera follow the player

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float cameraSize = 5f; // Set your desired camera size here.

    void Start()
    {
        Camera.main.orthographicSize = cameraSize; // Set the camera size.
    }
    void LateUpdate() {
        transform.position = target.position + offset;
    }
}
