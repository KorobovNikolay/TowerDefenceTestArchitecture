using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Asset
{
    [CreateAssetMenu (fileName = "AssetLevel", menuName = "Asset/Level")]
    public class LevelAsset : ScriptableObject
    {
        public SceneAsset scene;
        public SpawnWavesAsset spawnWaves;
    }
}