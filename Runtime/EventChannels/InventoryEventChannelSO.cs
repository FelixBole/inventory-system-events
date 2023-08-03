using UnityEngine.Events;
using UnityEngine;
using Slax.Inventory;

namespace Slax.EventSystem
{
    [CreateAssetMenu(menuName = "Events/Inventory/Inventory Event Channel")]
    public class InventoryEventChannelSO : EventChannelSO
    {
        public UnityAction<InventorySO> OnEventRaised;

        public void RaiseEvent(InventorySO value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}
