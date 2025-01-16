using AttackSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode attackKey;

        private AttackPerformer _attackPerformer;

        private void Update()
        {
            ListenForAttackInput();
        }

        private void ListenForAttackInput()
        {
            if (Input.GetKeyDown(attackKey))
            {
                _attackPerformer?.PerformAttack();
            }
        }

        public void Setup(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }
    }
}