﻿using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class PlayerMovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        
        Entities.ForEach((ref Translation pos, in MoveData moveData) =>
        {
            float3 normalizeDir = math.normalizesafe(moveData.direction);
            pos.Value += normalizeDir * moveData.speed * deltaTime;
        }).Run();
    }
}
