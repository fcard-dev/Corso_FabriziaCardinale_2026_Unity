using TMPro;
using UnityEngine;

public class ButtonScript2 : MonoBehaviour
{
    [SerializeField] private static int score = 0;
    [SerializeField] private TextMeshProUGUI _scoreText;

    public void Aumenta()
    {
        score++;
        _scoreText.text = score.ToString();
        Debug.Log("Punteggio aumentato.");
    }

    public void Diminuisci()
    {
        score--;
        _scoreText.text = score.ToString();
        Debug.Log("Punteggio diminuito.");
    }
}
