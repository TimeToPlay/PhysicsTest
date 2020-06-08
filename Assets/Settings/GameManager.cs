using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject playerPrefab;
    public GameObject cube;
    public Text cubeCountText;
    private int cubeCount = 1;
    
    private Entity playerEntityPrefab;
    private EntityManager manager;
    private BlobAssetStore blobAssetStore;
    
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        blobAssetStore = new BlobAssetStore();
        GameObjectConversionSettings settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, blobAssetStore);
        playerEntityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(playerPrefab, settings);
    }
    private void OnDestroy()
    {
        blobAssetStore.Dispose();
    }

    private void Start()
    {
        cubeCountText.text = cubeCount.ToString();
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        Entity newPlayerEntity = manager.Instantiate(playerEntityPrefab);

        Translation playerTrans = new Translation
        {
            Value = new float3(0, 0.5f, 0)
        };

        manager.AddComponentData(newPlayerEntity, playerTrans);
        CameraFollow.instance.playerEntity = newPlayerEntity;
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
