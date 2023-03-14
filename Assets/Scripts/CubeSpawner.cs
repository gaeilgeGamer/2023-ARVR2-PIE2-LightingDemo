using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Button spawnButton;

    private void Start()
    {
        spawnButton.onClick.AddListener(SpawnCube);
    }

    private void SpawnCube()
    {
        Instantiate(cubePrefab, transform.position, Quaternion.identity);
    }
}