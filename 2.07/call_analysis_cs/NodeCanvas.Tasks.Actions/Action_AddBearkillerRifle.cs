using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Gear;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace NodeCanvas.Tasks.Actions;

public class Action_AddBearkillerRifle : ActionTask
{
	public AssetReferenceT<GearItemData> m_RifleAsset;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_AddBearkillerRifle()
	{
	}
}
