using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    [SerializeField] GameObject[] candyArr;

    private static float waitTime;
    private int totalCandy = 0;
    private void Start()
    {
        waitTime = Random.Range(1f, 3f);
    }

    private void Update()
    {
        if  (waitTime <= 0 && totalCandy < 15) 
        {
            Debug.Log("MakeCandy");
            GameObject candy = Instantiate(GetCandy());
            candy.transform.position = new Vector3(Random.Range(-8, 8), 10, 0);
            totalCandy++;
            waitTime = Random.Range(1f, 3f);
        }
        else
        {
            waitTime -= Time.deltaTime;
        }

    }

    private GameObject GetCandy()
    {
        int candyNum = Random.Range(0, 8);
        //make candy types 3,4,5 more likely to spawn
        if (candyNum >= candyArr.Length)
        {
            candyNum -= 3;
        }
        return candyArr[candyNum];
    }
}
