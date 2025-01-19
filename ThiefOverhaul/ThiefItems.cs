using UnityEngine;
using DaggerfallWorkshop.Game.Formulas;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Entity;
using DaggerfallWorkshop.Game;
using Telescopes;

namespace ThiefOverhaul
{

    public class ItemLockpicks : DaggerfallUnityItem
    {
        ItemEquipTable itemEquipTable = GameManager.Instance.PlayerEntity.ItemEquipTable;


        public ItemLockpicks() : base(ItemGroups.MiscItems, ThiefOverhaul.templateIndex_Lockpick)
        {
            ToolTipString = "Grants owner a bonus in lock picking skills";
        }

        public override EquipSlots GetEquipSlot()
        {
            return itemEquipTable.GetFirstSlot(EquipSlots.Ring0, EquipSlots.Ring1);
        }

        public override SoundClips GetEquipSound()
        {
            return SoundClips.EquipChain;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemLockpicks).ToString();
            return data;
        }

    }

    public class ItemMark : DaggerfallUnityItem
    {
        ItemEquipTable itemEquipTable = GameManager.Instance.PlayerEntity.ItemEquipTable;

        public ItemMark() : base(ItemGroups.MiscItems, ThiefOverhaul.templateIndex_Mark)
        {
            ToolTipString = "Grants owner a bonus in streetwise skills";
        }

        public override EquipSlots GetEquipSlot()
        {
            return itemEquipTable.GetFirstSlot(EquipSlots.Mark0, EquipSlots.Mark1);
        }

        public override SoundClips GetEquipSound()
        {
            return SoundClips.EquipClothing;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemMark).ToString();
            return data;
        }

    }

    public class ItemBracelet : DaggerfallUnityItem
    {
        ItemEquipTable itemEquipTable = GameManager.Instance.PlayerEntity.ItemEquipTable;

        public ItemBracelet() : base(ItemGroups.MiscItems, ThiefOverhaul.templateIndex_Bracelet)
        {
            ToolTipString = "Grants owner a bonus in pickpocket skills";

        }

        public override EquipSlots GetEquipSlot()
        {
            return itemEquipTable.GetFirstSlot(EquipSlots.Bracelet0, EquipSlots.Bracelet1);
        }

        public override SoundClips GetEquipSound()
        {
            return SoundClips.EquipJewellery;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemBracelet).ToString();
            return data;
        }
    }

    public class ItemRope : DaggerfallUnityItem
    {
        ItemEquipTable itemEquipTable = GameManager.Instance.PlayerEntity.ItemEquipTable;

        public ItemRope() : base(ItemGroups.MiscItems, ThiefOverhaul.templateIndex_Bracer)
        {
            ToolTipString = "Grants owner a bonus in climbing skills";

        }

        public override EquipSlots GetEquipSlot()
        {
            return itemEquipTable.GetFirstSlot(EquipSlots.Bracer0, EquipSlots.Bracer1);
        }

        public override SoundClips GetEquipSound()
        {
            return SoundClips.EquipClothing;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemRope).ToString();
            return data;
        }

    }

    public class ItemPebbles : DaggerfallUnityItem
    {
        ItemEquipTable itemEquipTable = GameManager.Instance.PlayerEntity.ItemEquipTable;

        public ItemPebbles() : base(ItemGroups.MiscItems, ThiefOverhaul.templateIndex_Crystal)
        {
            ToolTipString = "Grants owner a bonus in stealth skills";

        }

        public override EquipSlots GetEquipSlot()
        {
            return itemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal0);
        }

        public override SoundClips GetEquipSound()
        {
            return SoundClips.EquipClothing;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemPebbles).ToString();
            return data;
        }
    }
}
