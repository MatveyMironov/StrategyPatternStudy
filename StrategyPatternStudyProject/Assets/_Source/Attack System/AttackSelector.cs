using System.Collections.Generic;

namespace AttackSystem
{
    public class AttackSelector
    {
        public AttackSelector(List<IAttackStrategy> attackStrategies, AttackPerformer attackPerformer)
        {
            SelectionBindings = new();

            foreach (var strategy in attackStrategies)
            {
                SelectionBinding selectionBinding = new(strategy, attackPerformer);
                SelectionBindings.Add(selectionBinding);
            }
        }

        public List<SelectionBinding> SelectionBindings { get; }

        public class SelectionBinding
        {
            private readonly IAttackStrategy _attackStrategy;
            private readonly AttackPerformer _attackPerformer;

            public SelectionBinding(IAttackStrategy attackStrategy, AttackPerformer attackPerformer)
            {
                _attackStrategy = attackStrategy;
                _attackPerformer = attackPerformer;
            }

            public void SelectAttack()
            {
                _attackPerformer.SetAttack(_attackStrategy);
            }
        }
    }
}