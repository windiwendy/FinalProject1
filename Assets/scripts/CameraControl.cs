
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    float offset;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);


    }
}
