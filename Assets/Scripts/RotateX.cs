using UnityEngine;

public class RotateX : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up *20* Time.deltaTime, Space.World);
    }
}
