using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoCollider : MonoBehaviour
{
    public bool activated = false;
    // Start is called before the first frame update
    private SphereCollider tomatoColl;
    private MeshCollider tomatoMesh;
    void Start()
    {
        tomatoColl = GetComponent<SphereCollider>();
        tomatoMesh = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(activated == true)
        {
            tomatoColl.enabled = true;
            tomatoMesh.enabled = true;
        }
    }
}
