using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    // Define the minimum and maximum volume values.
    public float minVolume = 0.0f;
    public float maxVolume = 1.0f;

    private void Start()
    {
        // Make sure you have a reference to the Slider component and AudioSource component.
        if (volumeSlider == null || audioSource == null)
        {
            Debug.LogError("VolumeSlider: Missing references! Make sure to assign Volume Slider and Audio Source in the Inspector.");
            return;
        }

        // Add a listener to the Slider's OnValueChanged event.
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    private void ChangeVolume(float sliderValue)
    {
        // Remap the slider value to the actual volume range.
        float volume = Mathf.Lerp(minVolume, maxVolume, sliderValue);

        // Update the audio source's volume based on the Slider's value.
        audioSource.volume = volume;
    }
}
