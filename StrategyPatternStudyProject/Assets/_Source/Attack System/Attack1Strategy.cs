using UnityEngine;

namespace AttackSystem
{
    public class Attack1Strategy : IAttackStrategy
    {
        private const string animationName = "Attack1";

        private readonly Animator _animator;
        private readonly int _animationHash;

        public Attack1Strategy(Animator animator)
        {
            _animator = animator;
            _animationHash = Animator.StringToHash(animationName);
        }

        public void PerformAttack()
        {
            _animator.SetTrigger(_animationHash);
        }
    }
}