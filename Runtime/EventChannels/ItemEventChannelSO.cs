using UnityEngine.Events;
using UnityEngine;
using Slax.Inventory;

namespace Slax.EventSystem
{
    [CreateAssetMenu(menuName = "Events/Inventory/Item Event Channel")]
    public class ItemEventChannelSO : EventChannelSO
    {
        public UnityAction<ItemSO> OnEventRaised;

        public void RaiseEvent(ItemSO value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}
