
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;




    // Update is called once per frame
    void Update()
    {
        if (target != null) { 
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
         }

    }
}
