using System.Collections;
using UnityEngine;

namespace Asset
{
    [CreateAssetMenu(fileName = "SpawnWavesAsset", menuName = "Asset/SpawnWaves")]
    public class SpawnWavesAsset : ScriptableObject
    {
        public EnemyAsset enemy;
        public int count;
        public float timeBeetwinSpawn;
    }
}