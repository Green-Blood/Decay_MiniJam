using Core.Player;
using Enemy;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerMovement playerMovement;
        [SerializeField] private EnemyMovement[] enemyMovements;
        

        private StateMachine _stateMachine;

        private void Awake()
        {
            _stateMachine = new StateMachine();
            _stateMachine.Enter(State.GameStart);
            
        }
    }
}