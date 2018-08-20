using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertakesdebugger : MonoBehaviour {

    private void OnDrawGizmosSelected()
    {
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;
        Gizmos.color = Color.white;
        foreach(var vert in mesh.vertices)
        {
            Gizmos.DrawSphere(transform.TransformPoint(vert), 0.1f);
        }
    }

}
