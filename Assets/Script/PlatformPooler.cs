using System.Collections.Generic;
using UnityEngine;

public class PlatformPooler : MonoBehaviour
{
    [System.Serializable]
    public class PlatformPool
    {
        public GameObject prefab;
        public int size;
        public string tag;
    }
    public static PlatformPooler instance;

    private Dictionary<string, Queue<GameObject>> platformPoolsDictionary;

    [SerializeField]
    public PlatformPool[] platformPools = new PlatformPool[5];

    public int _numberPlatform = 0;

    private void Awake()
    { 
        instance = this;

        platformPoolsDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (PlatformPool pool in platformPools)
        {
            Queue<GameObject> queueObjects = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject newPlatform = Instantiate(pool.prefab);

                newPlatform.SetActive(false);
                queueObjects.Enqueue(newPlatform);
            }
            platformPoolsDictionary.Add(pool.tag, queueObjects);
        }
    }
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            GetPlatform();
        }
    }
    private void SpawnFromPool(string tag, Vector3 position)
    { 
        GameObject gamePlatform = platformPoolsDictionary[tag].Dequeue();

        gamePlatform.SetActive(true);

        gamePlatform.transform.position = position;

        platformPoolsDictionary[tag].Enqueue(gamePlatform);
    }
    public void GetPlatform()
    {
        string tag;

        _numberPlatform++;

        Vector3 platformPosition = new Vector3(Random.Range(-2.28f, 2.34f), _numberPlatform + Random.Range(-0.3f, 0.3f), 2);

        if (_numberPlatform % 32 == 0)
        {
            tag = "gray platform";
        }
        else if (_numberPlatform % 27 == 0)
        {
            tag = "yellow platform";  
        }
        else if (_numberPlatform % 21 == 0)
        {
            tag = "jump platform";
        }     
        else if (_numberPlatform % 16 == 0)
        {
            tag = "blue platform";
        }
        else
        {
            tag = "green platform";
        }

        SpawnFromPool(tag, platformPosition);

    }
}
