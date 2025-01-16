using UnityEngine;

namespace AttackSystem
{
    public class Attack3Strategy : IAttackStrategy
    {
        private const string animationName = "Attack3";

        private readonly Animator _animator;
        private readonly int _animationHash;

        public Attack3Strategy(Animator animator)
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