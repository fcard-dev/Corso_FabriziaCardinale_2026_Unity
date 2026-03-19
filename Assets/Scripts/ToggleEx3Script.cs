using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleEx3 : MonoBehaviour
{
    public ToggleGroup toggleGroup;
    public List<Toggle> togglesLst;
    public TextMeshProUGUI riassunto;

    void Start()
    {
        foreach (Toggle t in togglesLst)
        {
            t.onValueChanged.AddListener(SelezionaToggle);
        }

        SelezionaToggle(true);
    }

    void SelezionaToggle(bool stato)
    {
        Toggle attivo = toggleGroup.GetFirstActiveToggle();

        if (attivo != null)
        {
            riassunto.text = $"Elemento visibile: {attivo.name}";
            Debug.Log($"selezionato: {attivo.name}");
        }
        else
        {
            riassunto.text = $"Elemento visibile: nessuno";
            Debug.Log($"Nessun selezionato");
        }
    }
}
