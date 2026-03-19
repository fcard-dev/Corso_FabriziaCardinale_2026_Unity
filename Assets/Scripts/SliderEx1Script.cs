using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderEx1Script : MonoBehaviour
{
    public Slider slider;
    public float volumeSlider;
    public TextMeshProUGUI volumeTesto;

    void Start()
    {
        slider.onValueChanged.AddListener(ImpostaVolume);
    }

    void ImpostaVolume(float volume)
    {
        volumeSlider = volume;
        volumeTesto.text = volumeSlider.ToString("P0");
    }
}
