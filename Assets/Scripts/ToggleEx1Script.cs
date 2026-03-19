using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleEx1Script : MonoBehaviour
{
    public TextMeshProUGUI luceTesto;
    public Toggle toggleLuce;

    void Start()
    {
        toggleLuce.onValueChanged.AddListener(ImpostaLuce);
    }

    void ImpostaLuce(bool stato)
    {
        Debug.Log($"Stato luce: {stato}");
        luceTesto.text = $"Stato luce: {stato}";
    }
}
