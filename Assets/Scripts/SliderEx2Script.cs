using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderEx2Script : MonoBehaviour
{
    public Slider slider;
    public Light luceSlider;
    public TextMeshProUGUI luceTesto;

    void Start()
    {
        slider.onValueChanged.AddListener(ImpostaLuce);
    }

    void ImpostaLuce(float luce)
    {
        luceSlider.intensity = luce;
        luceTesto.text = luce.ToString("F0");
    }
}
