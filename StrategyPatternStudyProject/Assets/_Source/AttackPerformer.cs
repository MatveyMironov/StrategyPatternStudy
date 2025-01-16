using UnityEngine;

namespace AttackSystem
{
    public class AttackPerformer
    {
        private IAttackStrategy _currentStrategy;

        public void SetAttack(IAttackStrategy strategy)
        {
            _currentStrategy = strategy;
        }

        public void PerformAttack()
        {
            _currentStrategy?.PerformAttack();
        }
    }
}