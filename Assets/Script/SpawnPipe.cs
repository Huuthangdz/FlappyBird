using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] private GameObject Pipe;
    [SerializeField] private float MaxTime = 5f;
    [SerializeField] private float heightRange = 5f;

    private float Timer;

    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > MaxTime)
        {
            Spawn();
            Timer = 0;
        }
        Timer += Time.deltaTime;
    }

    public void Spawn()
    {
        Vector3 SpawnPos = transform.position + new Vector3(0, Random.Range(0,heightRange));
        GameObject PipeSpawn1 = Instantiate(Pipe, SpawnPos, Quaternion.identity);

        Destroy(PipeSpawn1,10f);
    }
}
