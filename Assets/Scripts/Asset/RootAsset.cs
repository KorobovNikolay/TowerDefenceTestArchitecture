using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asset
{
    [CreateAssetMenu(fileName = "RootAsset", menuName = "Asset/Root")]
    public class RootAsset : ScriptableObject
    {
        public List<LevelAsset> levels;
    }
}