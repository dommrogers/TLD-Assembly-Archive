using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

public class GearItemData : ScriptableObject
{
	private AssetReferenceGearItem m_PrefabReference;

	private GearType m_Type;

	private GameplayTag m_GameplayTag;

	private bool m_RemainInInventoryOnDrop;

	private bool m_AlwaysConsiderHarvested;

	private GearDummyType m_GearDummyType;

	private float m_BaseWeightKG;

	private float m_MaxHP;

	private float m_DailyHPDecay;

	private float m_ScentIntensity;

	private float m_GearBreakConditionThreshold;

	private bool m_AffectedByProjectilePhysics;

	private LocalizedString m_LocalizedName;

	private LocalizedString m_LocalizedDescription;

	private ConditionTableType m_ConditionType;

	private bool m_PromptsPersistUntilUsed;

	private bool m_AllowFavoriting;

	private GearItemInventoryIconData m_IconData;

	private float m_DamageBlendStartPercent;

	private float m_DamageShaderUpdateThreshold;

	private AssetReferenceTexture2D m_CoverFlowMainTexture;

	private AssetReferenceTexture2D m_CoverFlowDamageTexture;

	private AssetReferenceTexture2D m_CoverFlowBlendTexture;

	private AssetReferenceTexture2D m_CoverFlowOpenedTexture;

	private GearMovementSound m_MovementSoundCategory;

	private AK.Wwise.Event m_PickupAudio;

	private AK.Wwise.Event m_StowAudio;

	private AK.Wwise.Event m_PutBackAudio;

	private AK.Wwise.Event m_WornOutAudio;

	private AK.Wwise.Event m_CookingSlotPlacementAudio;

	public AssetReferenceGearItem PrefabReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public GameplayTag GameplayTag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(GameplayTag);
		}
	}

	public bool RemainInInventoryOnDrop
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool AlwaysConsiderHarvested
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public GearDummyType GearDummyType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(GearDummyType);
		}
	}

	public float BaseWeightKG
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float MaxHP
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float DailyHPDecay
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float ScentIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float GearBreakConditionThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public bool AffectedByProjectilePhysics
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public string DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string DisplayNameLocID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string Description
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string DescriptionLocID
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public ConditionTableType ConditionType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ConditionTableType);
		}
	}

	public bool PromptsPersistUntilUsed
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool AllowFavoriting
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public float DamageBlendStartPercent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float DamageShaderUpdateThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public GearItemInventoryIconData IconData
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
	}

	public AssetReferenceTexture2D CoverFlowMainTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public AssetReferenceTexture2D CoverFlowDamageTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public AssetReferenceTexture2D CoverFlowBlendTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 64)]
		get
		{
			return null;
		}
	}

	public AssetReferenceTexture2D CoverFlowOpenedTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public GearMovementSound MovementSoundCategory
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(GearMovementSound);
		}
	}

	public AK.Wwise.Event PickupAudio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	public AK.Wwise.Event StowAudio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public AK.Wwise.Event PutBackAudio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public AK.Wwise.Event WornOutAudio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public AK.Wwise.Event CookingSlotPlacementAudio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
	[Calls(Type = typeof(ConditionTable), Member = "GetDisplayNameWithCondition")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDisplayNameWithCondition(float normalizedCondition, string overrideDisplayLocID = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool IsGearType(GearType type)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public GearItemData()
	{
	}
}
