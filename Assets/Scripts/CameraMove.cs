using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float panSpeed = 10f;
    public float panBorerThickness = 10f;
   // public float scrollspeed = 20f;
    public Vector2 panlimit;
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorerThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
          if (Input.GetKey("s") || Input.mousePosition.y <= panBorerThickness)
          {
              pos.z -= panSpeed * Time.deltaTime;
          }
          if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorerThickness)
          {
              pos.x += panSpeed * Time.deltaTime;
          }
          if (Input.GetKey("a") || Input.mousePosition.x <=  panBorerThickness)
          {
              pos.x -= panSpeed * Time.deltaTime;
          }

       // float scroll= Input.GetAxis("Mouse ScrollWheel");
     //   pos.y += scroll * scrollspeed *100f* Time.deltaTime;
        
        pos.x = Mathf.Clamp(pos.x, -panlimit.x, panlimit.x);
        pos.z= Mathf.Clamp(pos.z, -panlimit.y, panlimit.y);

        transform.position = pos;
    }
}
