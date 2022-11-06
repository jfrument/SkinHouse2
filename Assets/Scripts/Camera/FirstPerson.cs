using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    private float sensitivity = 100f;
    public GameObject Player;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
         //float rotateHorizontal = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
         float rotateVertical = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        //transform.Rotate(Vector3.up * rotateHorizontal * sensitivity);
        xRotation -= rotateVertical;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        float rotateHorizontal = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        if (gameObject.activeInHierarchy)
            Player.transform.Rotate(Vector3.up * rotateHorizontal * sensitivity * Time.deltaTime);


    }
}
