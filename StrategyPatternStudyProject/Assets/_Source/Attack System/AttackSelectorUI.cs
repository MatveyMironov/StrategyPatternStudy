using System;
using UnityEngine;

namespace AttackSystem
{
    public class AttackSelectorUI : MonoBehaviour
    {
        [SerializeField] private SelectionButton selectionButtonPrefab;
        [SerializeField] private Transform selectionButtonsContent;

        private SelectionButton _selectedButton;

        public void Setup(AttackSelector attackSelector)
        {
            foreach (var binding in attackSelector.SelectionBindings)
            {
                SelectionButton selectionButtonInstance = Instantiate(selectionButtonPrefab, selectionButtonsContent);
                ButtonBinding buttonBinding = new(selectionButtonInstance, binding, SelectButton);
            }
        }

        public void SelectButton(SelectionButton selectionButton)
        {
            _selectedButton?.HideSelection();
            _selectedButton = selectionButton;
            _selectedButton.ShowSelection();
        }

        private class ButtonBinding
        {
            private readonly SelectionButton _selectionButton;
            private readonly AttackSelector.SelectionBinding _selectionBinding;
            private readonly Action<SelectionButton> _displaySelection;

            public ButtonBinding(SelectionButton selectionButton, AttackSelector.SelectionBinding selectionBinding, Action<SelectionButton> displaySelection)
            {
                _selectionButton = selectionButton;
                _selectionBinding = selectionBinding;

                _selectionButton.OnButtonClicked += _selectionBinding.SelectAttack;
                _displaySelection = displaySelection;
                _selectionButton.OnButtonClicked += DisplaySelection;
            }

            private void DisplaySelection()
            {
                _displaySelection(_selectionButton);
            }
        }
    }
}