using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Bed : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public GameObject m_BedRollMesh;

	public GameObject m_BedRollPlacedMesh;

	public float m_ConditionPercentGainPerHour;

	public float m_WarmthBonusCelsius;

	public float m_UinterruptedRestPercentGainPerHour;

	public float m_PercentChanceReduceWolfAttackWhenSleeping;

	public float m_PercentChanceReduceBearAttackWhenSleeping;

	public string m_OpenAudio;

	public string m_CloseAudio;

	public Transform m_BodyPlacementTransform;

	private GearItem m_Bedroll;

	private BedRollState m_BedRollState;

	private string m_BodyGuid;

	private CarryableBody m_Body;

	private static List<Bed> s_StaticBeds;

	private static List<Bed> s_BedsToLinkToBodies;

	private static BedSaveDataProxy m_BedSaveDataProxy;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Bed), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 7)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Bed), Member = "Deserialize")]
	[Calls(Type = typeof(Bed), Member = "FindBedByGuid")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Bed), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Bed), Member = "PlaceBody")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void PostDeserialize()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Degrade(float hoursUsed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsWornOut()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateWarmthBonusLabel")]
	[CalledBy(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public float GetWarmthBonusCelsius()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayOpenAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void PlayCloseAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Rest), Member = "OnPickUp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetBedRolledMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetBedPlacedMesh")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(Bed), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void SetState(BedRollState state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BedRollState GetState()
	{
		return default(BedRollState);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	public bool IsOccupied()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Bed), Member = "PlaceBody")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	public bool CanBodyBePlaced()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CalledBy(Type = typeof(Bed), Member = "PostDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	public void PlaceBody(CarryableBody body)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveBody(CarryableBody body)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CarryableBody GetOccupant()
	{
		return null;
	}

	[CalledBy(Type = typeof(Bed), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	private static Bed FindBedByGuid(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Bed()
	{
	}
}
