using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float jeda = 1.3f;
    public GameObject[] obyekSampah;

    void Start()
    {
        InvokeRepeating(nameof(SpawnSampah), 1f, jeda);
    }

    void SpawnSampah()
    {
        if (obyekSampah.Length == 0) return;

        int index = Random.Range(0, obyekSampah.Length);
        Vector3 posisiSpawn = transform.position;
        Instantiate(obyekSampah[index], posisiSpawn, Quaternion.identity);
    }
}
