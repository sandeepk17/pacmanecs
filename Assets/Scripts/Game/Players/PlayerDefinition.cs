using UnityEngine;

namespace Game.Players {
    [CreateAssetMenu(menuName = "PacManEcs/" + nameof(PlayerDefinition))]
    public sealed class PlayerDefinition : ScriptableObject {
        [Range(0, 10)] public float StartSpeed;

        [Range(0, 10)] public int StartLives;
    }
}