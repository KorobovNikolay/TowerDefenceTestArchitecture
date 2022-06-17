using Enemy;
using System.Collections;
using UnityEngine;

namespace Asset
{
    [CreateAssetMenu (fileName = "AssetEnemy", menuName = "Asset/Enemy")]
    public class EnemyAsset : ScriptableObject
    {
        public int startHealth;
        public EnemyView view;
    }
}