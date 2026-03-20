using TMPro;
using UnityEngine;

public class InputFieldEx1Script : MonoBehaviour
{
    public TMP_InputField nome;
    public TextMeshProUGUI testo;

    public void MostraNome()
    {
        testo.text = nome.text;
    }
}
