using System;
using UnityEngine;

namespace TicTacToe
{
    [Serializable]
    public struct SceneData
    {
        [SerializeField] private string _scene;
        public string Scene => _scene;

        [SerializeField] private SceneType _type;
        public SceneType Type => _type;
    }
}
