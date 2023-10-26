using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spikes Object for controlling the game")]
    public GameObject spikes;
    [Header("Default Height")]
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects")
    }

    // Update is called once per frame
    void Update()
    {

    }
}
