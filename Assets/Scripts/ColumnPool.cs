﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize =5;
    public GameObject columnPrefab;
    private GameObject[] columns;
    private Vector2 objectPoolPosition= new Vector2(-16,0);
    private float timeSinceLastSpawned;
    public float spawRate;
    public float columnMin= -2.9f;
    public float columnMax= 1.4f;
    private float spawnXPosition= 10f;
    private int currentColumn; 

    // Start is called before the first frame update
    void Start()
    {
        columns= new GameObject[columnPoolSize];
        for(int i=0; i<columnPoolSize; i++){
           columns[i]= Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
           SpawnColumn();   
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (!GameController.instance.gameOver && timeSinceLastSpawned>= spawRate){
            timeSinceLastSpawned=0;
            SpawnColumn();
            }
        
    }

    void SpawnColumn(){
         float spawnYPosition= Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position=new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            if(currentColumn>= columnPoolSize){
                currentColumn=0;    
            }
    }

}
