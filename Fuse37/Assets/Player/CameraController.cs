using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject EyeObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.EyeObj.transform.position;


        transform.position = new Vector3(EyeObj.transform.position.x, 0, transform.position.z);
    }
}
