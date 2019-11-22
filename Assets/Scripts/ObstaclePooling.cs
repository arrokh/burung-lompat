using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePooling : MonoBehaviour
{
    public int obstaclesLength = 5;
    public GameObject obstaclesPrefab;
    public float spwanRate = 4.0f;
    public float minPosition = -1.0f;
    public float maxPosition = 3.5f;

    private GameObject[] _obstacles;
    private Vector2 _objectPoolPosition;
    private float _timeSinceLastSpawned;
    private float _spawnXPosition = 10.0f;
    private int _currentObstacles;

    void Start()
    {
        _obstacles = new GameObject[obstaclesLength];
        for (int i = 0; i < obstaclesLength; i++)
            _obstacles[i] = (GameObject)Instantiate(obstaclesPrefab, Vector3.up * 20, Quaternion.identity);
    }

    void Update()
    {
        _timeSinceLastSpawned += Time.deltaTime;

        if (GameController.instance.gameOver == false &&
            _timeSinceLastSpawned >= spwanRate)
        {
            _timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(minPosition, maxPosition);
            _obstacles[_currentObstacles].transform.position = new Vector2(_spawnXPosition, spawnYPosition);
            _currentObstacles++;
            if (_currentObstacles >= obstaclesLength)
                _currentObstacles = 0;
        }
    }
}
