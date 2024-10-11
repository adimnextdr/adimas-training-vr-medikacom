using System.Collections.Generic;
using UnityEngine;

public class ObjectValidatorManager : MonoBehaviour {
    public List<ItemType> selectedItemTypes = new List<ItemType>();

    public void SetItemType(ItemType itemType) {
        Debug.Log(itemType);
        selectedItemTypes.Add(itemType);
    }

    public List<ItemType> GetSelectedItemTypes() {
        return selectedItemTypes;
    }

    public void ClearSelectedItemTypes() {
        selectedItemTypes.Clear();
    }

    public bool IsValidItem(ItemType itemType) {
        return selectedItemTypes.Contains(itemType);
    }

    public bool AreAllItemsValid(ObjectValidator[] objectValidators) {
        List<ItemType> itemTypes = new List<ItemType>();

        foreach (var validator in objectValidators) {
            // Ensure the item is checked first before validating
            ItemType itemType = validator.GetItemSocketed();
            if (itemType != ItemType.None) {
                itemTypes.Add(itemType);
            } else {
                itemTypes.Add(ItemType.None);
            }
        }

        foreach (ItemType itemType in itemTypes) {
            if (!IsValidItem(itemType) && itemType != ItemType.None) {
                return false;
            }
        }

        return true;
    }
}


public enum ItemType {
    teabox, teabox1, teabox2, teabox3, teabox4, teabox5, teabox6, teabox7, teabox8, teabox9, teabox10, teabox11, bean, bean1, bean2, bean3, bean4, bean5, bean6, bean7, bean8, bean9, bean10, bean11, bean12, bean13, bean14, pasta, pasta1, pasta2, pasta3, pasta4, pasta5, pasta6, pasta7, pasta8, pasta9, pasta10, pasta11, pasta12, pasta13, pasta14, pasta15, pasta16, pasta17, pasta18, choco, choco1, choco2, choco3, choco4, cigg, cigg1, cigg2, cigg3, cigg4, cigg5, cigg6, cigg7, None
}
