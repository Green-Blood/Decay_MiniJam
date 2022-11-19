using System;
using Core.Player;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent agent;
        [SerializeField] private float distanceToRun = 50f;
        
        
        private PlayerMovement _playerMovement;
        public void Construct(PlayerMovement player)
        {
            _playerMovement = player;
        }

        private void Update()
        {
            
        }

        private void GetDistance()
        {
            var distance = Vector3.Distance(transform.position, _playerMovement.transform.position);
            if (distance < distanceToRun)
            {
                var dirToPlayer = transform.position - _playerMovement.transform.position;
                var newPos = transform.position + dirToPlayer;

                agent.SetDestination(newPos);
            }
        }
    }
}
