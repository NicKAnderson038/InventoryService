using InvertoryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvertoryService.Services
{
    public interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);

        Dictionary<string, InventoryItems> GetInventoryItems();
    }
}
