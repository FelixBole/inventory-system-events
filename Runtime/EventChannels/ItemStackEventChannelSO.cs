using UnityEngine.Events;
using UnityEngine;
using Slax.Inventory;

namespace Slax.EventSystem
{
    [CreateAssetMenu(menuName = "Events/Inventory/Item Stack Event Channel")]
    public class ItemStackEventChannelSO : EventChannelSO
    {
        public UnityAction<ItemStack> OnEventRaised;

        public void RaiseEvent(ItemStack value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}
