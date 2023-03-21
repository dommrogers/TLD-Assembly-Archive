using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class Cookable : MonoBehaviour
{
	public enum CookableType
	{
		Meat,
		Grub,
		Liquid
	}

	private PanelReference<Panel_Inventory> m_Inventory;

	public GearItem m_CookedPrefab;

	public float m_CookTimeMinutes;

	public float m_ReadyTimeMinutes;

	public string m_PutInPotAudio;

	public string m_CookAudio;

	public float m_PotableWaterRequiredLiters;

	public int m_NumUnitsRequired;

	public float m_LitersLampOilPerKG;

	public CookableType m_CookableType;

	public float m_WarmUpNearFireRange;

	public MeshRenderer m_LiquidMeshRenderer;

	public bool m_DoNotCookWhenDropped;

	public Material[] m_CookingPotMaterialsList;

	public Material[] m_CookingPotRawMaterialsList;

	public Material[] m_RuinedMaterials;

	public Mesh m_MeshPotStyle;

	public Mesh m_MeshRawPotStyle;

	public Mesh m_MeshCanStyle;

	public Mesh m_MeshRawCanStyle;

	public Mesh m_MeshFryingPanStyle;

	public Mesh m_MeshRawFryingPanStyle;

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	public void MaybeStartWarmingUpDueToNearbyFire()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public void MaybeReattachToNearbyFire(CookingPotItem cookingPot)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsNearFire()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public float GetCookTimeMinutesForCaloriesRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public Cookable()
	{
	}
}
