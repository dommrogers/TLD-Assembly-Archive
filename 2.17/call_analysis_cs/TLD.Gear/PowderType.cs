using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;

namespace TLD.Gear;

public class PowderType : ScriptableObject
{
	private LocalizedString m_PowderName;

	private LocalizedString m_PowderDecription;

	private GearItemData m_DefaultContainer;

	public LocalizedString PowderName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public LocalizedString PowderDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	public GearItemData DefaultContainer
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForPowder")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	public Texture2D GetInventoryIcon()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PowderType()
	{
	}
}
