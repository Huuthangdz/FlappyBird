using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePrefabs : MonoBehaviour
{
    [SerializeField] private float speed = 3f;


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;    
    }


}
