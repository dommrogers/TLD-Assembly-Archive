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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Bed), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Bed), Member = "SerializeAll")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Bed), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Bed), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Bed), Member = "PlaceBody")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void PostDeserialize()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallerCount(Count = 3)]
	public void Degrade(float hoursUsed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsWornOut()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateWarmthBonusLabel")]
	[CalledBy(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	public float GetWarmthBonusCelsius()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayOpenAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayCloseAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetBedRolledMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetBedPlacedMesh")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnPickUp")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Bed), Member = "Deserialize")]
	public void SetState(BedRollState state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BedRollState GetState()
	{
		return default(BedRollState);
	}

	[CalledBy(Type = typeof(Bed), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	[CalledBy(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	public bool IsOccupied()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[CalledBy(Type = typeof(Bed), Member = "PlaceBody")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	public bool CanBodyBePlaced()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Bed), Member = "PostDeserialize")]
	[Calls(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	public void PlaceBody(CarryableBody body)
	{
	}

	[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private static Bed FindBedByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldPerformBedInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Bed()
	{
	}
}
