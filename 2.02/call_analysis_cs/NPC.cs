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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public NPCSavedData()
		{
		}
	}

	public class NPCGlobalSaveData
	{
		public string m_ActiveGuid;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void HandlePickUp()
	{
	}

	[CalledBy(Type = typeof(AiTarget), Member = "IsDead")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAlive()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(NPC), Member = "IsIndoors")]
	[CalledBy(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPC), Member = "FindNearest")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsBeingCarried()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public bool IsConditionUpdateEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsIndoors()
	{
		return false;
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

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPC), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Serialize")]
	[Calls(Type = typeof(NPCCondition), Member = "Serialize")]
	[Calls(Type = typeof(NPCFreezing), Member = "Serialize")]
	[Calls(Type = typeof(NPCThirst), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public NPCSavedData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPC), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void Deserialize(NPCSavedData savedData)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetNextAmbientAudioTimer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private void DoConditionUpdate()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void DoUpdate(UpdateFlags flags)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "Awake")]
	[CalledBy(Type = typeof(NPC), Member = "FindAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "MaybeReparentAnimatedInteractions")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAmbientVoiceOver()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CalledBy(Type = typeof(NPC), Member = "HandlePickUp")]
	[CalledBy(Type = typeof(NPC), Member = "SetConditionUpdateEnabled")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateTODHours()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(Action_NPCClearActive), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ClearActive()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static NPC GetFromGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "GetFromGuid")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static NPC GetActive()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[CalledBy(Type = typeof(NPC), Member = "HandlePickUp")]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(NPC), Member = "IsActive")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CalledBy(Type = typeof(NPC), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool HasActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsActive(string guid)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeGlobal(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static string SerializeGlobal()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(NPC), Member = "Serialize")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(NPC), Member = "FindNPCByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static void FindAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(NPC), Member = "IsAlive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[Calls(Type = typeof(NPC), Member = "DoUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static void UpdateAll()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static NPC FindNPCByGuid(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentNPCCondition")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static NPC FindNearest(Vector3 position, float maxDistance, FindFlags flags)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NPC()
	{
	}
}
