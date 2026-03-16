using UnityEngine;

//ciclo di vita
public class MyFirstScript : MonoBehaviour
{
    void Awake() => Debug.Log("Primo risveglio");
    void OnEnable() => Debug.Log("mi sono abilitato");
    void Start() => Debug.Log("primo Start");
    void Update() => Debug.Log("ad ogni frame");
    void FixedUpdate() => Debug.Log("intervallo fisso");
    void LateUpdate() => Debug.Log("alla fine del frame");
    void OnDisable() => Debug.Log("mi sono disabilitato");
    void OnDestroy() => Debug.Log("sto per essere distrutto");
}
