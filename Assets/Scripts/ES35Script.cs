using UnityEngine;

public class ES25Script : MonoBehaviour
{
    private Vector3 _direzione;

    //spostamento oggetti
    [SerializeField] private float _speedVerticale = 2f;
    [SerializeField] private float _speedOrizzontale = 3f;
    [SerializeField] private GameObject _prefabDaIstanziare;
    [SerializeField] private Transform _spawnPoint;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * _speedVerticale * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * _speedVerticale * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * _speedOrizzontale * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * _speedOrizzontale * Time.deltaTime;
        }

        Debug.Log("Posizione globale:" + transform.position);
        Debug.Log("Posizione locale:" + transform.localPosition);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_prefabDaIstanziare, _spawnPoint.position, Quaternion.identity);
        }
    }

    void Awake() => Debug.Log("Primo risveglio");
    void OnEnable() => Debug.Log("mi sono abilitato");
    void Start() => Debug.Log("primo Start");
    void FixedUpdate() => Debug.Log("intervallo fisso");
    void OnDisable() => Debug.Log("mi sono disabilitato");
    void OnDestroy() => Debug.Log("sto per essere distrutto");

}
