using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GearItemSaveDataProxy
{
	public float m_HoursPlayed;

	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public int m_InstanceIDProxy;

	public float m_CurrentHPProxy;

	public float m_NormalizedCondition;

	public bool m_BeenInPlayerInventoryProxy;

	public bool m_BeenInContainerProxy;

	public bool m_BeenInspectedProxy;

	public bool m_ItemLootedProxy;

	public bool m_HasBeenOwnedByPlayer;

	public bool m_RolledSpawnChanceProxy;

	public bool m_WornOut;

	public string m_StackableItemSerialized;

	public string m_FoodItemSerialized;

	public string m_LiquidItemSerialized;

	public string m_FlareItemSerialized;

	public string m_FlashlightItemSerialized;

	public string m_KeroseneLampItemSerialized;

	public string m_ClothingItemSerialized;

	public string m_WeaponItemSerialized;

	public string m_WaterSupplySerialized;

	public string m_BedSerialized;

	public string m_SmashableItemSerialized;

	public string m_MatchesItemSerialized;

	public string m_SnareItemSerialized;

	public string m_InProgressItemSerialized;

	public string m_TorchItemSerialized;

	public string m_CollectibleNoteSerialized;

	public string m_EvolveItemSerialized;

	public string m_ObjectGuidSerialized;

	public string m_MissionObjectSerialized;

	public string m_ResearchItemSerialized;

	public float m_WeightKG;

	public bool m_HarvestedByPlayer;

	public bool m_IsInSatchel;

	public int m_SatchelIndex;

	public string m_OwnershipOverrideSerialized;

	public string m_BodyHarvestSerialized;

	public bool m_LockedInContainer;

	public int m_GearItemSaveVersion;

	public string m_CookingPotItemSerialized;

	public string m_PlacePointGuidSerialized;

	public string m_PlacePointNameSerialized;

	public bool m_NonInteractive;

	public bool m_HasBeenEquippedAndUsed;

	public string m_InspectSerialized;

	public string m_RigidBodySerialized;

	public bool m_StoneItemThrown;

	public string m_PowderItemSerialized;

	public string m_MillableSerialized;

	public string m_SprayPaintCanSerialized;

	public string m_NoiseMakerSerialized;

	public string m_BowItemSerialized;

	public HandheldShortwaveSaveDataProxy m_HandheldshortwaveSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public GearItemSaveDataProxy()
	{
	}
}
