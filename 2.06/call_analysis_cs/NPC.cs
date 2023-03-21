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
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	public void HandlePickUp()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[CalledBy(Type = typeof(AiTarget), Member = "IsDead")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAlive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPC), Member = "FindNearest")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(NPC), Member = "IsIndoors")]
	public bool IsBeingCarried()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool IsConditionUpdateEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
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
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPC), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(NPC), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 21)]
	public NPCSavedData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPC), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(NPCSavedData savedData)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetNextAmbientAudioTimer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPC), Member = "FindAll")]
	[CalledBy(Type = typeof(NPC), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "MaybeReparentAnimatedInteractions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC), Member = "SetConditionUpdateEnabled")]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
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
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(NPC), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(NPC), Member = "IsActive")]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(NPC), Member = "HandlePickUp")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	public static bool HasActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	public static bool IsActive(string guid)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	public static string SerializeGlobal()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 8)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NPC), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(NPC), Member = "DoUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentNPCCondition")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	public static NPC FindNearest(Vector3 position, float maxDistance, FindFlags flags)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NPC()
	{
	}
}
