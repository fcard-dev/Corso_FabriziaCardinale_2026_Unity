using TMPro;
using UnityEngine;

public class InputFieldEx3Script : MonoBehaviour
{
    public TMP_InputField nome;
    public TMP_InputField email;
    public TMP_InputField messaggio;
    public TextMeshProUGUI testo;

    public void VerificaCampi()
    {
        nome.image.color = Color.white;
        email.image.color = Color.white;
        messaggio.image.color = Color.white;
        
        bool verifica = true;

        if (string.IsNullOrEmpty(nome.text))
        {
            nome.image.color = Color.red;
            verifica = false;
        }

         if (string.IsNullOrEmpty(email.text))
        {
            email.image.color = Color.red;
            verifica = false;
        }

         if (string.IsNullOrEmpty(messaggio.text))
        {
            messaggio.image.color = Color.red;
            verifica = false;
        }

        if(verifica)
        {
            testo.text = "Campi compilati correttamente";
        }
    }
}
