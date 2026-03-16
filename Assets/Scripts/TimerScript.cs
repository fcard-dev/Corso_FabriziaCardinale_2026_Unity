using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    private bool _timerAttivo = true;
    private float _time;

    [SerializeField] private TextMeshProUGUI _timerText;

    void Update()
    {
        if (_timerAttivo)
        {
            _time += Time.deltaTime;
            _timerText.text = _time.ToString();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _timerAttivo = !_timerAttivo;
        }
    }
}
