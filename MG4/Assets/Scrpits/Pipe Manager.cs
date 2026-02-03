using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{

    [SerializeField] private GameObject _pipePrefab;
    [SerializeField] private float _minY = -2f;
    [SerializeField] private float _maxY = 2f;

    private GameObject _pipe;
    private float _timer;
    [SerializeField] private float _spawnInterval = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //_timer += Time.deltaTime;
        //if (_timer >= _spawnInterval)
        /*
        while (_timer >= _spawnInterval)
        {
            Instantiate(_pipe,transform.position,Quaternion.identity);
            _pipe = _pipeVariations[SelectPipe()];
            _timer -= _spawnInterval;
        }
        */
        /*
        _timer += Time.deltaTime;

        if (_timer >= _spawnInterval)
        {
            Instantiate(_pipeVariations[SelectPipe()], transform.position, Quaternion.identity);

            _timer -= _spawnInterval; // keep leftover time
        }
        */

        _timer += Time.deltaTime;

        if (_timer >= _spawnInterval)
        {
            SpawnPipe(_pipePrefab);
            _timer = 0;
        }
    }

    /*
    private int SelectPipe()
    {
        int _pipeIndex = Random.Range(0, _pipeVariations.Length);
        return _pipeIndex;
    }


    */

    private void SpawnPipe(GameObject sprite)
    {
        GameObject newThing = Instantiate(sprite) as GameObject;
        placeThing(newThing);
    }
    private void placeThing(GameObject sprite)
    {
        // IMPORTANT: min then max
        float tempY = Random.Range(-0.5f, 7.5f);
        sprite.transform.position = new Vector2(5f, tempY);
    }
}
