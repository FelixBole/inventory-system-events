using UnityEngine.Events;
using UnityEngine;
using Slax.Inventory;

namespace Slax.EventSystem
{
    [CreateAssetMenu(menuName = "Events/Inventory/Inventory Update Event Channel")]
    public class InventoryUpdateEventChannelSO : EventChannelSO
    {
        public UnityAction<InventoryUpdate> OnEventRaised;

        public void RaiseEvent(InventoryUpdate value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}
