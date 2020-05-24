using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotation : MonoBehaviour
{
    public Transform transformToCopy;
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.rotation = transformToCopy.rotation;
        
    }
}
