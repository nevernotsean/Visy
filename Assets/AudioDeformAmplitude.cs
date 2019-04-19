using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Deform;

public class AudioDeformAmplitude : MonoBehaviour {
    private RippleDeformer deform;
    public UnityAtoms.FloatVariable Input;
    public float multiplier;
    // public Transform originalTransform;

    private float originalAmplitude;

    void Start () {
        deform = GetComponent<RippleDeformer> ();
        // originalTransform = transform;
        originalAmplitude = deform.Amplitude;
    }

    void Update () {
        deform.Amplitude = originalAmplitude * Input.Value * multiplier;
    }
}