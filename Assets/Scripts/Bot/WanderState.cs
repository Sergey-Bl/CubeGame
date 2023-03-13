using Bot;
using UnityEngine;

namespace DefaultNamespace
{
    public class WanderState : IABotState {
        private readonly Vector3 _direction;
        private IABotState _nextState;

        public WanderState(Vector3 direction)
        {
            _direction = direction;
        }

        public Vector3 GetDirection(Vector3 transformPosition)
        {
            if (BlockChecker.HasBlockInDirection(transformPosition, _direction))
            {
                return _direction;
            }
            else
            {
                _nextState = new WaitState(2f, _direction);
                return Vector3.zero;
            }
        }

        public void OnUpdate(float deltaTime)
        {
        }

        public IABotState GetNextState()
        {
            return _nextState;
        }
    }
}