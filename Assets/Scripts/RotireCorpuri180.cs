using UnityEngine;

public class RotireCorpuri180 : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }
}
