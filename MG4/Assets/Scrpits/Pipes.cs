using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Collider2D _pointCollider;
    // Start is called before the first frame update

    public delegate void ScoreEvent();
    public event ScoreEvent _onScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right.x * -1 * _speed * Time.deltaTime, 0, 0);
    }


    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("score");
            _onScore?.Invoke();  
        }

    }
    */

    
}
