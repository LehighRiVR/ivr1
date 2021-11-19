using UnityEngine;
using System.Collections;

public class FlipNormals : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = this.GetComponent<MeshFilter>().mesh;

        Vector3[] normals = mesh.normals;
        for (int i = 0; i < normals.Length; i++)
            normals[i] = -1 * normals[i];

        mesh.normals = normals;

        for (int i = 0; 1 < mesh.subMeshCount; i++)
        {
            int[] tris = mesh.GetTriangles(i);
            for (int j = 0; j < tris.Length; j+=3)
            {
                //swap order of tri vertices
                int temp = tris[j];
                tris[j] = tris[j + 1];
                tris[j + 1] = temp;
            }

            mesh.SetTriangles(tris, i);
        }
    }

}
