using System;
using UnityEngine;
using UnityEngine.UI;

namespace AttackSystem
{
    public class SelectionButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Image selectionIndicator;

        public event Action OnButtonClicked;

        private void Start()
        {
            button.onClick.AddListener(InvokeOnButtonClicked);
        }

        public void ShowSelection()
        {
            selectionIndicator.enabled = true;
        }

        public void HideSelection()
        {
            selectionIndicator.enabled = false;
        }

        private void InvokeOnButtonClicked()
        {
            OnButtonClicked?.Invoke();
        }
    }
}