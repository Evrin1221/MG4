using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _pipeVariations;
    [SerializeField] private float _spawnInterval;

    private GameObject _pipe;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        _pipe = _pipeVariations[SelectPipe()];
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _spawnInterval)
        {
            Instantiate(_pipe,transform.position,Quaternion.identity);
            _pipe = _pipeVariations[SelectPipe()];
            _timer = 0;
        }
    }

    private int SelectPipe()
    {
        int _pipeIndex = Random.Range(0, _pipeVariations.Length);
        return _pipeIndex;
    }
}
