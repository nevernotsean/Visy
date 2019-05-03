using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public class UpdateTransform : MonoBehaviour
{
    public Vector3Variable Position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Position.Value, Time.deltaTime * 100);
    }
}
