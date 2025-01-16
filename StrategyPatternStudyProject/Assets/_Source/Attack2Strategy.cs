using UnityEngine;

namespace AttackSystem
{
    public class Attack2Strategy : IAttackStrategy
    {
        private const string animationName = "Attack2";

        private readonly Animator _animator;
        private readonly int _animationHash;

        public Attack2Strategy(Animator animator)
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