using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour {
    public Transform[] Points;
    public float Speed = 1f, Distance = 2f;
    private int _currentPoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Points != null)
        {
            if (_currentPoint == Points.Length) _currentPoint = 0;
            float _currentDistance = Vector3.Distance(transform.position, Points[_currentPoint].position);
            if (_currentDistance <= Distance) _currentPoint++;
            // transform.LookAt(Points[_currentPoint].position);
            transform.position = Vector3.MoveTowards(transform.position, Points[_currentPoint].position, Speed * Time.deltaTime);
        }
    }


}
