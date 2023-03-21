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

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	public void MaybeStartWarmingUpDueToNearbyFire()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	public void MaybeReattachToNearbyFire(CookingPotItem cookingPot)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	public bool IsNearFire()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 1)]
	public float GetCookTimeMinutesForCaloriesRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public Cookable()
	{
	}
}
