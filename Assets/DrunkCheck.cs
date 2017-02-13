using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class DrunkCheck : MonoBehaviour {

    private TiltShift _tiltShift;

    private BeingDrunk _beingDrunk;

    private float blurAmount;
    private float blurSize;
    private float downSample;

    void Start()
    {
        _beingDrunk = GetComponent<BeingDrunk>();
        _tiltShift = GetComponent<TiltShift>();
    }

    void Update()
    {
        blurAmount = (15 / _beingDrunk._slider.maxValue) * _beingDrunk._sliderValue;
        blurSize = (25 / _beingDrunk._slider.maxValue) * _beingDrunk._sliderValue;
        if (_beingDrunk._sliderValue == 0)
            downSample = 0;
        else
            downSample = 1;
        _tiltShift.blurArea = blurAmount;
        _tiltShift.maxBlurSize = blurSize;
        _tiltShift.downsample = (int)downSample;
    }
}
