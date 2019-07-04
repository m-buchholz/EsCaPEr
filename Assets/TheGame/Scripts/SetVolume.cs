using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("Volume", 1f);
    }

    void Update()
    {
        slider.onValueChanged.AddListener(delegate { SetLevel(slider.value); });
    }

    public void SetLevel(float sliderVol)
    {
        mixer.SetFloat("MasterVol", Mathf.Log10(sliderVol) * 20);
        PlayerPrefs.SetFloat("Volume", sliderVol);
    }
}
