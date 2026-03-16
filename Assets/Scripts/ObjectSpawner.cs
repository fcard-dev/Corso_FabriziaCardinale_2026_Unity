using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabToSpawn;
    [SerializeField] private Transform _spawnPoint;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            var instObject = Instantiate(_prefabToSpawn, _spawnPoint.position, Quaternion.identity);
            Renderer instObjectRenderer = instObject.GetComponent<Renderer>();
            instObjectRenderer.material.color = Random.ColorHSV(0f,1f);
        }
    }
}
