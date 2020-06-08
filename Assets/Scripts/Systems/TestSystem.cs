
// using Unity.Entities;
// using Unity.Mathematics;
// using Unity.Physics;
// using Unity.Transforms;
// using UnityEngine.UIElements;
//
// public class TestSystem : SystemBase
// {
//     protected override void OnUpdate()
//     {
//         float dT = Time.DeltaTime; 
//
//         Entities
//             .ForEach(
//                 (ref Translation translation) =>
//                 {
//                     translation = new Translation()
//                     {
//                         Value = new float3(translation.Value.x + dT, translation.Value.y, translation.Value.z)
//                     };
//                 }
//             )
//             .ScheduleParallel();
//     }
// }
