using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using UnityEngine.UI;

public class BeingDrunk : MonoBehaviour {

	private Twirl twirl;
	public float _sliderValue;
	private Quaternion _armRotation;
	[SerializeField]private float _amount;
	[SerializeField]public Slider _slider;

    AnimationHandler _anim;

	void Start () {
		twirl = GetComponent<Twirl> ();
		_slider = _slider.GetComponent<Slider> ();
		_sliderValue = _slider.value;

        _anim = GameObject.FindObjectOfType<AnimationHandler>();
	}
	
	void Update () {
		_slider.value = _sliderValue;
		_sliderValue -= _amount / 2;
		twirl.angle = _sliderValue;

		if (Input.GetKey (KeyCode.Space)) {
            _anim._drink = true;
			_sliderValue += _amount;
		} else if(!Input.GetKey(KeyCode.Space)){
            _anim._drink = false;
		}
		if (_sliderValue <= 0) {
			_sliderValue = 0;
		}
		if (_sliderValue >= _slider.maxValue) {
			_sliderValue = _slider.maxValue;
		}
	}
}
