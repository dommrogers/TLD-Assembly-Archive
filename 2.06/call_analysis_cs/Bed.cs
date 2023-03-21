using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Bed : MonoBehaviour
{
	private PanelReference<Panel_Rest> m_Rest;

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

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(Bed), Member = "SerializeAll")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Bed), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "PlaceBody")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 5)]
	public static void PostDeserialize()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	public void Degrade(float hoursUsed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool IsWornOut()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateWarmthBonusLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	public float GetWarmthBonusCelsius()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void PlayOpenAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void PlayCloseAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetBedRolledMesh")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnPickUp")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Bed), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetBedPlacedMesh")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessAltFire")]
	[CalledBy(Type = typeof(Bed), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	[CalledBy(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	public bool IsOccupied()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Bed), Member = "PlaceBody")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	public bool CanBodyBePlaced()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Bed), Member = "PostDeserialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	public void PlaceBody(CarryableBody body)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveBody(CarryableBody body)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CarryableBody GetOccupant()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static Bed FindBedByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldPerformBedInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[CallsUnknownMethods(Count = 2)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Bed()
	{
	}
}
