using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public struct MoveData : IComponentData
{
    public float3 direction;
    public float speed;
    public float turnSpeed;
}
