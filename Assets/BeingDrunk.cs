using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using UnityEngine.UI;

public class BeingDrunk : MonoBehaviour {

	private Twirl twirl;
	private float _sliderValue;
	private Quaternion _armRotation;
	[SerializeField]private GameObject _rightArm;
	[SerializeField]private float _amount;
	[SerializeField]private Slider _slider;

	void Start () {
		twirl = GetComponent<Twirl> ();
		_slider = _slider.GetComponent<Slider> ();
		_sliderValue = _slider.value;
		_armRotation = new Quaternion (_rightArm.transform.localRotation.x, 40, _rightArm.transform.localRotation.z, 0);
	}
	
	void Update () {
		_slider.value = _sliderValue;
		_sliderValue -= _amount / 10;
		twirl.angle = _sliderValue;
		if (Input.GetKeyDown (KeyCode.Space)) {
			_rightArm.transform.localRotation = _armRotation;
			_sliderValue += _amount;
		} else {
			_rightArm.transform.localRotation = new Quaternion(_rightArm.transform.localRotation.x, 0, _rightArm.transform.localRotation.z, 0);
		}
		if (_sliderValue <= 0) {
			_sliderValue = 0;
		}
		if (_sliderValue >= _slider.maxValue) {
			_sliderValue = _slider.maxValue;
		}
	}
}
