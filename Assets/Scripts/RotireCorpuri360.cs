using UnityEngine;

public class RotireCorpuri360 : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.one * 20 * Time.deltaTime);
    }
}
