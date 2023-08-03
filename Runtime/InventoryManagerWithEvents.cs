using UnityEngine;
using Slax.EventSystem;

namespace Slax.Inventory
{
    /// <summary>
    /// This class extends the Inventory manager to add the firing
    /// of events using the Slax.EventSystem.
    /// </summary>
    public class InventoryManagerWithEvents : InventoryManager
    {
        [Header("Broadcasting Events")]
        [SerializeField] private InventoryUpdateEventChannelSO _onItemAddEvent;
        [SerializeField] private InventoryUpdateEventChannelSO _onItemRemoveEvent;
        [SerializeField] private InventoryUpdateEventChannelSO _onItemSoldEvent;
        [SerializeField] private InventoryUpdateEventChannelSO _onItemBoughtEvent;

        public override InventoryUpdate AddItem(ItemSO item, int amount)
        {
            InventoryUpdate iu = base.AddItem(item, amount);
            _onItemAddEvent?.RaiseEvent(iu);
            return iu;
        }

        public override InventoryUpdate RemoveItem(ItemSO item, int amount)
        {
            InventoryUpdate iu = base.RemoveItem(item, amount);
            _onItemRemoveEvent?.RaiseEvent(iu);
            return iu;
        }

        public override InventoryUpdate Buy(ItemSO item, int amount, float priceMultiplier)
        {
            InventoryUpdate iu = base.Buy(item, amount, priceMultiplier);
            _onItemBoughtEvent?.RaiseEvent(iu);
            return iu;
        }

        public override InventoryUpdate BuyForFree(ItemSO item, int amount)
        {
            InventoryUpdate iu = base.BuyForFree(item, amount);
            _onItemBoughtEvent?.RaiseEvent(iu);
            return iu;
        }

        public override InventoryUpdate Sell(ItemSO item, int amount)
        {
            InventoryUpdate iu = base.Sell(item, amount);
            _onItemSoldEvent?.RaiseEvent(iu);
            return iu;
        }
    }
}