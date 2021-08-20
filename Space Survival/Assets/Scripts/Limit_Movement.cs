using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit_Movement : MonoBehaviour
{

    // Update is called once per frame
    void Update(){
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -11f, 11f),
            Mathf.Clamp(transform.position.y, -8f, 8f), transform.position.z);
    }
}
