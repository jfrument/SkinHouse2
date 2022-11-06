using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 3f;
    private float sensitivity = 1000f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));

        //float rotateHorizontal = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        //transform.Rotate(Vector3.up * rotateHorizontal * sensitivity * Time.deltaTime);

    }
}
