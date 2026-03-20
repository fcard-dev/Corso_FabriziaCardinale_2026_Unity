using TMPro;
using UnityEngine;

public class InputFieldEx2Script : MonoBehaviour
{
    public TMP_InputField numero;
    public TextMeshProUGUI testo;

    void Start()
    {
        numero.onEndEdit.AddListener(ControlloNumero);
    }

    void ControlloNumero(string numeroVerifica)
    {
        int n = int.Parse(numeroVerifica);

        if (n > 100)
        {
            testo.text = "Numero maggiore di 100";
        }
        else
        {
            testo.text = "Numero minore di 100";
        }
    }
}
