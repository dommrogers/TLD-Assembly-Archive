using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Cookable : MonoBehaviour
{
	public enum CookableType
	{
		Meat,
		Grub,
		Liquid
	}

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

	public Mesh m_MeshPotStyle;

	public Mesh m_MeshRawPotStyle;

	public Mesh m_MeshCanStyle;

	public Mesh m_MeshRawCanStyle;

	public Mesh m_MeshFryingPanStyle;

	public Mesh m_MeshRawFryingPanStyle;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	public void MaybeStartWarmingUpDueToNearbyFire()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void MaybeReattachToNearbyFire(CookingPotItem cookingPot)
	{
	}

	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsNearFire()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetCookTimeMinutesForCaloriesRemaining()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Cookable()
	{
	}
}
