using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject cube;
    public Text cubeCountText;
    private int cubeCount = 1;
    void Start()
    {
        cubeCountText.text = cubeCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTenCubes()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cube, new Vector3(i * 3 - 15, 15, 11), Quaternion.identity, transform);
        }

        cubeCount += 30;
        cubeCountText.text = cubeCount.ToString();
    }
}
