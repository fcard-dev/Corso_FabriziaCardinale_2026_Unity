using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderEx3Script : MonoBehaviour
{
    public Slider slider;
    public GameObject palla;
    public TextMeshProUGUI dimensioneTesto;

    void Start()
    {
        slider.onValueChanged.AddListener(ImpostaDimensione);
    }

    void ImpostaDimensione(float grandezza)
    {
        palla.transform.localScale = new Vector3(grandezza, grandezza, grandezza);
        dimensioneTesto.text = grandezza.ToString("F0");
    }

    public void ResetGrandezza()
    {
        slider.value = 2f;
    }

    public void Turn()
    {
        slider.interactable = !slider.interactable;
    }
}
