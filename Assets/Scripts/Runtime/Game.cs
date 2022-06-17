using Asset;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Runtime
{
    public static class Game
    {
        public static Player Player { get; private set; }
        public static RootAsset RootAsset { get; private set; }
        public static LevelAsset CurrentLevel { get; private set; }

        public static void SetRootAsset(RootAsset rootAsset)
        {
            RootAsset = rootAsset;
        }

        public static void StartLevel(LevelAsset levelAsset)
        {
            CurrentLevel = levelAsset;
            SceneManager.LoadScene(levelAsset.scene.name);
            Player = new Player();

            Runner runner = Object.FindObjectOfType<Runner>();
                   runner.StartRunning();
        }
    }
}
