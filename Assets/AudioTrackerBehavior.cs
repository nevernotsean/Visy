using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public class AudioTrackerBehavior : MonoBehaviour {
    public float lowInput { get; set; }
    public float midInput { get; set; }
    public float highInput { get; set; }

    public FloatVariable SpecrumLow;
    public FloatVariable SpecrumMid;
    public FloatVariable SpecrumHigh;
    // Start is called before the first frame update
    void Start () { }

    // Update is called once per frame
    void Update () {
        SpecrumLow.SetValue (lowInput);
        SpecrumMid.SetValue (midInput);
        SpecrumHigh.SetValue (highInput);
    }
}