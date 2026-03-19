using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownEx1Script : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TextMeshProUGUI testo;
    void Start()
    {
        List<string> options = new List<string> { "Rosso", "Verde", "Blu" };
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }

    public void Aggiornamento()
    {
        if (dropdown.value == 0)
        {
            testo.text = "Colore rosso";
            testo.color = Color.red;
        }
        else if (dropdown.value == 1)
        {
            testo.text = "Colore verde";
            testo.color = Color.green;
        }
        else if (dropdown.value == 2)
        {
            testo.text = "Colore blu";
            testo.color = Color.blue;
        }
    }
}
