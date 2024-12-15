using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireworkController : MonoBehaviour
{
    public ParticleSystem fireworkPrefab;
    public Transform spawnPoint;

    public void StartFireworks()
    {
        Instantiate(fireworkPrefab, spawnPoint.position, Quaternion.identity);
    }
}

