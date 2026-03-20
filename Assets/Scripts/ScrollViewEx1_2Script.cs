using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewEx1_2Script : MonoBehaviour
{
    public GameObject gameObject;
    public ScrollRect scrollRect;

    void Start()
    {
        if (scrollRect == null)
        {
            scrollRect = GetComponent<ScrollRect>();
        }

        for (int i = 0; i < 20; i++)
        {
            int numero = i + 1;
            GameObject gameObject1 = Instantiate(gameObject, scrollRect.content);

            TextMeshProUGUI textComponent = gameObject1.GetComponentInChildren<TextMeshProUGUI>();
            if (textComponent != null)
            {
                textComponent.text = $"Pulsante {numero}";
            }

            gameObject1.GetComponent<Button>().onClick.AddListener(() => MostraNumero(numero));
        }
    }

    void MostraNumero(int numero)
    {
        Debug.Log($"Numero: {numero}");
    }
}
