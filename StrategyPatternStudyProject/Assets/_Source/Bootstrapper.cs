using AttackSystem;
using InputSystem;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private AttackSelectorUI attackSelectorUI;
        [SerializeField] private Animator animator;

        private void Awake()
        {
            BootStrap();
        }

        private void BootStrap()
        {
            AttackPerformer attackPerformer = new();

            inputListener.Setup(attackPerformer);

            Attack1Strategy attack1Strategy = new(animator);
            Attack2Strategy attack2Strategy = new(animator);
            Attack3Strategy attack3Strategy = new(animator);

            List<IAttackStrategy> attackStrategies = new() { attack1Strategy, attack2Strategy, attack3Strategy };

            AttackSelector attackSelector = new(attackStrategies, attackPerformer);

            attackSelectorUI.Setup(attackSelector);
        }
    }
}