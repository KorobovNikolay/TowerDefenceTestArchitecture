using Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Runtime
{
    public class Startup : MonoBehaviour
    {
        [SerializeField] private RootAsset _rootAsset;

        private void Awake()
        {
            Game.SetRootAsset(_rootAsset);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Game.StartLevel(_rootAsset.levels[0]);
        }
    }
}
