using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{

    [SerializeField] private TMP_Text _pointText;
    [SerializeField] private AudioSource _pointSound;
    private int _score=0;

    // Start is called before the first frame update
    void Start()
    {
        PointDetector._onScore += AddPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddPoint()
    {
        _score++;
        _pointText.text = "Points: "+ _score.ToString();
        _pointSound.Play();
    }
}
