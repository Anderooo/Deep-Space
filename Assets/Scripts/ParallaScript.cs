using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaScript : MonoBehaviour
{
    public GameObject reference;
    public float slowFactor;

    Vector3 prevPos;

    private void Start()
    {
        prevPos = reference.transform.position;
    }

    private void Update()
    {
        transform.position = transform.position + ((reference.transform.position - prevPos) / slowFactor);
        prevPos = reference.transform.position;
    }
}
