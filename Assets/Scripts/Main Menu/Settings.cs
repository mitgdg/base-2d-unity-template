using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] AudioMixer mainMixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SetMusicVolume() {
        float volume = musicSlider.value;
        mainMixer.SetFloat("Music", Mathf.Log10(volume) * 20); 
    }
    public void SetSFXVolume() {
        float volume = sfxSlider.value;
        mainMixer.SetFloat("SFX", Mathf.Log10(volume) * 20); 
    }


}
