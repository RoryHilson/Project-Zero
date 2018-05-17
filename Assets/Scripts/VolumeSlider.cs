using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class VolumeSlider : MonoBehaviour
{
	public Slider mainSlider;
	public float volume;


	//Invoked when a submit button is clicked.
	public void SubmitSliderSetting()
	{
		volume = mainSlider.value;
		//Displays the value of the slider in the console.
		Debug.Log(mainSlider.value);
	}
}