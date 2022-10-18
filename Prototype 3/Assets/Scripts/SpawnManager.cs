using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsticlePrefab;

    private Vector3 _spawnPos = new Vector3(15, -3, 0);

    private float _startDelay = 2;

    private float _repeatRate = 2.5f;

    private PlayerMovement _playerScript;

    // Start is called before the first frame update
    void Start()
    {
      _playerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();

      InvokeRepeating("SpawnObsticle", _startDelay, _repeatRate);  
    }

    void SpawnObsticle()
    {
      //if(!_playerScript.isGameOver) also works below
        if(_playerScript.isGameOver == false)
        {
             Instantiate(obsticlePrefab, _spawnPos, obsticlePrefab.transform.rotation);
        }
    }
}
