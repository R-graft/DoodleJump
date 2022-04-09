using System.Collections;
using UnityEngine;

public class SpawnEnemyScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _flyes = new GameObject[2];

    [SerializeField]
    private GameObject _holePrefab;

    private void Start()
    {
        StartCoroutine(HoleSpawner());
        StartCoroutine(FlySpawner());
    }
    IEnumerator HoleSpawner()
    {
        while (true)
        { 
            yield return new WaitForSecondsRealtime(40);

            if (!GameObject.FindGameObjectWithTag("Hole"))
            {
                GameObject newHole = Instantiate(_holePrefab);

                newHole.transform.position = new Vector3(Random.Range(-2.7f, 2.45f), PlatformPooler.instance._numberPlatform + 0.3f, 2f);
            }
            else { yield return null; }
        }
    }
    IEnumerator FlySpawner()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(30);

            if (!GameObject.FindGameObjectWithTag("Enemy"))
            {
                GameObject newFly = Instantiate(_flyes[Random.Range(0, 2)]);

                newFly.transform.position = new Vector3(Random.Range(-3.3f, 0.95f), PlatformPooler.instance._numberPlatform + 0.3f, 2f);
            }
            else { yield return null; }
        }
    }
}
