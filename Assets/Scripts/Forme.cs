using UnityEngine;

public class Forme : MonoBehaviour
{
    Mesh mesh;
    int[] triangles;
    Vector3[] vertices;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    private void Start()
    {
        MakeMesh();
        CreateMesh();
    }

    void MakeMesh()
    {
        vertices = new Vector3[]{new Vector3(0,0,0),new Vector3(0,0,1),new Vector3(1,0,0), new Vector3(1,0,1)};

        triangles = new int[] { 0, 1, 2, 2,1,3 };
    }

    void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;

    }
}