using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class NPC : MonoBehaviour
{
	public class NPCSavedData
	{
		public string m_AfflictionsSerialized;

		public string m_ConditionSerialized;

		public string m_FreezingSerialized;

		public string m_ThirstSerialized;

		public bool m_EnableConditionUpdate;

		public string m_Guid;

		public float m_LastUpdatedTODHours;

		public float m_NextAmbientAudioTime;

		public bool m_HasBeenInteractedWith;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public NPCSavedData()
		{
		}
	}

	public class NPCGlobalSaveData
	{
		public string m_ActiveGuid;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public NPCGlobalSaveData()
		{
		}
	}

	private enum UpdateFlags
	{
		None,
		UpdateCondition,
		CinematicActive
	}

	public enum FindFlags
	{
		None,
		InteractedWith,
		ConditionUpdating
	}

	public static bool s_DisableConditionUpdates;

	public static bool s_Invulnerable;

	public LocalizedString m_DisplayName;

	public bool m_EnableConditionUpdate;

	public float m_AmbientAudioTimeVariance;

	public float m_MinTimeBetweenAmbientAudio;

	public string m_AmbientAudioEvent;

	public float m_MinTimeBetweenCarryAmbientAudio;

	public string m_CarryAmbientAudioEvent;

	[NonSerialized]
	public NPCAfflictions m_AfflictionsComponent;

	[NonSerialized]
	public NPCCondition m_Condition;

	[NonSerialized]
	public NPCFreezing m_Freezing;

	[NonSerialized]
	public NPCThirst m_Thirst;

	[NonSerialized]
	public NPCVoice m_Voice;

	[NonSerialized]
	public CarryableBody m_Body;

	[NonSerialized]
	public string m_Guid;

	[NonSerialized]
	public IndoorSpaceTrigger m_IndoorSpaceTrigger;

	private bool m_Initialized;

	private float m_LastUpdatedTODHours;

	private float m_NextAmbientAudioTime;

	private bool m_HasBeenInteractedWith;

	private static List<NPC> s_NPCList;

	private static string s_ActiveGuid;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void HandlePickUp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[CalledBy(Type = typeof(AiTarget), Member = "IsDead")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	public bool IsAlive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPC), Member = "FindNearest")]
	[CalledBy(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPC), Member = "IsIndoors")]
	public bool IsBeingCarried()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsConditionUpdateEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsIndoors()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	public void SetConditionUpdateEnabled(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetHasBeenInteractedWith(bool flag)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	public void PerformInteraction()
	{
	}

	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateInteraction")]
	[CallsUnknownMethods(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(NPC), Member = "SerializeAll")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public NPCSavedData Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPC), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(NPCSavedData savedData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	public void ResetNextAmbientAudioTimer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	private void DoConditionUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	private void DoUpdate(UpdateFlags flags)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NPC), Member = "FindAll")]
	[CalledBy(Type = typeof(NPC), Member = "Awake")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "MaybeReparentAnimatedInteractions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	private void UpdateAmbientVoiceOver()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CalledBy(Type = typeof(NPC), Member = "SetConditionUpdateEnabled")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(NPC), Member = "HandlePickUp")]
	private void UpdateTODHours()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(Action_NPCClearActive), Member = "OnExecute")]
	public static void ClearActive()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static NPC GetFromGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "GetFromGuid")]
	public static NPC GetActive()
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(NPC), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(NPC), Member = "IsActive")]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(NPC), Member = "HandlePickUp")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	public static bool HasActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	public static bool IsActive(string guid)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	public static void SetActive(NPC npc)
	{
	}

	[CallerCount(Count = 0)]
	public static IEnumerable<NPC> GetAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DeserializeGlobal(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static string SerializeGlobal()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NPC), Member = "Deserialize")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	public static void FindAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(NPC), Member = "DoUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "IsAlive")]
	public static void UpdateAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static NPC FindNPCByGuid(string guid)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentNPCCondition")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	public static NPC FindNearest(Vector3 position, float maxDistance, FindFlags flags)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPC()
	{
	}
}
