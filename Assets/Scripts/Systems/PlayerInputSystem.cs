using System;
using Unity.Entities;
using UnityEngine;

public class PlayerInputSystem : SystemBase
{
    protected override void OnUpdate()
    {

        Entities.ForEach((ref MoveData moveData, in InputData inputData) =>
        {
            //Debug.Log("UP KEY PRESSED: " + Input.GetKey(inputData.upKey));
            bool isUpKeyPressed = Input.GetKey(inputData.upKey);
            bool isDownKeyPressed = Input.GetKey(inputData.downKey);
            bool isLeftKeyPressed = Input.GetKey(inputData.leftKey);
            bool isRightKeyPressed = Input.GetKey(inputData.rightKey);
            
            moveData.direction.z = Convert.ToInt32(isUpKeyPressed);
            moveData.direction.z -= Convert.ToInt32(isDownKeyPressed);
            moveData.direction.x = Convert.ToInt32(isRightKeyPressed);
            moveData.direction.x -= Convert.ToInt32(isLeftKeyPressed);

        }).Run();
    }
}
