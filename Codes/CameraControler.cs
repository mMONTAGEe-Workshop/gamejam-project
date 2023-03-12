using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public float rotateSpeed = 10.0f;
    public float Speed = 5f;
    private float _mult = 1f;
    public float zoomSpeed = 10.0f;

    private void Update() 
    { 
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        

        float rotate = 0f;
        if(Input.GetKey(KeyCode.Q))
            rotate = -1f;
            else if (Input.GetKey(KeyCode.E))
            rotate = 1f;
            //shiftov 2 angam araganal@
            _mult = Input.GetKey(KeyCode.LeftShift) ? 2f : 1f;


        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * rotate * _mult, Space.World);      
        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime * _mult * Speed, Space.Self);

        transform.position += transform.up * zoomSpeed *Time.deltaTime * Input.GetAxis("Mouse ScrollWheel");
        transform.position = new Vector3
        (
            


            
        );

    }


}
