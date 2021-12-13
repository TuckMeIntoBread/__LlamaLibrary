﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using Buddy.Coroutines;
using ff14bot.Managers;
using LlamaLibrary.Extensions;
using LlamaLibrary.Logging;

namespace LlamaLibrary.Helpers
{
    public static class InventoryHelpers
    {
        private static readonly string Name = "InventoryHelpers";
        private static readonly Color LogColor = Colors.White;
        private static readonly LLogger Log = new LLogger(Name, LogColor);
        public static async Task LowerQualityAndCombine(int itemId)
        {
            var HQslots = InventoryManager.FilledSlots.Where(slot => slot.RawItemId == itemId && slot.IsHighQuality);

            if (HQslots.Any())
            {
                HQslots.First().LowerQuality();
                await Coroutine.Sleep(1000);
            }

            var NQslots = InventoryManager.FilledSlots.Where(slot => slot.RawItemId == itemId && !slot.IsHighQuality);

            if (NQslots.Count() > 1)
            {
                var firstSlot = NQslots.First();
                foreach (var slot in NQslots.Skip(1))
                {
                    slot.Move(firstSlot);
                    await Coroutine.Sleep(500);
                }
            }
        }

        public static async Task CombineStacks(IEnumerable<BagSlot> bagSlotsEnumerable)
        {
            var bagSlots = bagSlotsEnumerable.ToArray();
            if (!bagSlots.Any())
            {
                return;
            }

            var groupedSlots = bagSlots
                .Where(x => x.IsValid && x.IsFilled && (x.Item?.StackSize ?? 0) > 1)
                .GroupBy(x => x.TrueItemId)
                .Where(x => x.Count(slot => slot.Count < slot.Item.StackSize) > 1);

            foreach (var slotGrouping in groupedSlots)
            {
                // Skip if item is a collectable.
                if (slotGrouping.Key > 500_000 && slotGrouping.Key < 1_000_000)
                {
                    continue;
                }

                bool isHq = slotGrouping.Key > 1_000_000;
                uint itemId = isHq ? slotGrouping.Key - 1_000_000 : slotGrouping.Key;
                string itemName = DataManager.GetItem(itemId)?.CurrentLocaleName ?? $"UNKNOWN(ID: {itemId})";
                Log.Information($"Combining stacks of {itemName}{(isHq ? " (HQ)" : string.Empty)}");

                var bagSlotArray = slotGrouping.OrderByDescending(x => x.Count).ToArray();
                var moveToIndex = Array.FindIndex(bagSlotArray, x => x.Count < x.Item.StackSize);
                if (moveToIndex < 0)
                {
                    continue;
                }

                for (var i = bagSlotArray.Length - 1; i > moveToIndex; i--)
                {
                    var moveFromSlot = bagSlotArray[i];
                    if (moveFromSlot == null || !moveFromSlot.IsValid || !moveFromSlot.IsFilled)
                    {
                        continue;
                    }

                    var curCount = bagSlotArray[moveToIndex].Count;
                    var result = moveFromSlot.Move(bagSlotArray[moveToIndex]);
                    if (result)
                    {
                        await Coroutine.Wait(3000, () => curCount != bagSlotArray[moveToIndex].Count);
                    }

                    await Coroutine.Yield();

                    var curMoveTo = bagSlotArray[moveToIndex];
                    if (curMoveTo.Count >= curMoveTo.Item.StackSize)
                    {
                        moveToIndex = Array.FindIndex(bagSlotArray, x => x.IsValid && x.IsFilled && x.Count < x.Item.StackSize);
                    }
                }
            }
        }
    }
}