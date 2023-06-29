using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;

namespace TLD.Gear;

public class LiquidType : ScriptableObject
{
	public enum LiquidQuality
	{
		Potable,
		NonPotable,
		Unsafe
	}

	private GearItemData m_DefaultContainer;

	private float m_Density;

	private LocalizedString m_LiquidName;

	private LocalizedString m_LiquidDescription;

	private GearLiquidTypeEnum m_LegacyLiquidType;

	private LiquidQuality m_Quality;

	public GearItemData DefaultContainer
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public float Density
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public LocalizedString LiquidName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public LocalizedString LiquidDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
	}

	public LiquidQuality Quality
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(LiquidQuality);
		}
	}

	public bool IsDrinkable
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool IsPotable
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public GearLiquidTypeEnum LegacyLiquidType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(GearLiquidTypeEnum);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	public Texture2D GetInventoryIcon()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public LiquidType()
	{
	}
}
