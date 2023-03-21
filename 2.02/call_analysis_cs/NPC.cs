using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public NPCSavedData()
		{
		}
	}

	public class NPCGlobalSaveData
	{
		public string m_ActiveGuid;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CalledBy(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CallsUnknownMethods(Count = 2)]
	public void HandlePickUp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CalledBy(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	public bool IsAlive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPC), Member = "FindNearest")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(NPC), Member = "IsIndoors")]
	[CalledBy(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsBeingCarried()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public bool IsConditionUpdateEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsIndoors()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[CallerCount(Count = 0)]
	public void SetConditionUpdateEnabled(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetHasBeenInteractedWith(bool flag)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPCThirst), Member = "Serialize")]
	[CalledBy(Type = typeof(NPC), Member = "SerializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCFreezing), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCCondition), Member = "Serialize")]
	public NPCSavedData Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[CalledBy(Type = typeof(NPC), Member = "DeserializeAll")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(NPCSavedData savedData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
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
	[Calls(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DoConditionUpdate()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	private void DoUpdate(UpdateFlags flags)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(NPC), Member = "FindAll")]
	[CalledBy(Type = typeof(NPC), Member = "Awake")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "MaybeReparentAnimatedInteractions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateAmbientVoiceOver()
	{
	}

	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CalledBy(Type = typeof(NPC), Member = "HandlePickUp")]
	[CalledBy(Type = typeof(NPC), Member = "SetConditionUpdateEnabled")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateTODHours()
	{
	}

	[CalledBy(Type = typeof(Action_NPCClearActive), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ClearActive()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallsUnknownMethods(Count = 3)]
	public static NPC GetFromGuid(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(NPC), Member = "GetFromGuid")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static NPC GetActive()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPC), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(NPC), Member = "HandlePickUp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC), Member = "IsActive")]
	public static bool HasActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[CallerCount(Count = 2)]
	public static bool IsActive(string guid)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void SetActive(NPC npc)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static IEnumerable<NPC> GetAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeGlobal(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	public static string SerializeGlobal()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NPC), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 11)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NPC), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "FindNPCByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CallsUnknownMethods(Count = 7)]
	public static void FindAll()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsAlive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[Calls(Type = typeof(NPC), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 7)]
	public static void UpdateAll()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static NPC FindNPCByGuid(string guid)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentNPCCondition")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	public static NPC FindNearest(Vector3 position, float maxDistance, FindFlags flags)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public NPC()
	{
	}
}
