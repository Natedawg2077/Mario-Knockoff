using UnityEngine;
//satij
//march 17th 
//Code to make camera follow the player

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate() {
        transform.position = target.position + offset;
    }
}
