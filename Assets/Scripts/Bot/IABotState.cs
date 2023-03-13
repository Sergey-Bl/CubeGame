using UnityEngine;

namespace Bot
{
    public interface IABotState
    {
        public Vector3 GetDirection(Vector3 transformPosition);
        public void OnUpdate(float deltaTime);
        public IABotState GetNextState();
    }
}