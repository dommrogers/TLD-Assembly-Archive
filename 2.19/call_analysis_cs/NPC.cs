using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.BigCarry;
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
	public BodyBigCarryItem m_BodyBigCarryItem;

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

	[CallerCount(Count = 0)]
	public void HandlePickUp()
	{
	}

	[CalledBy(Type = typeof(AiTarget), Member = "IsDead")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
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
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CalledBy(Type = typeof(NPC), Member = "FindNearest")]
	[CalledBy(Type = typeof(NPCDisableConditionUpdateEnforcer), Member = "Update")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsBeingCarried()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "GetHoverText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPC), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public NPCSavedData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPC), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[Calls(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(NPCSavedData savedData)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "OnCarried")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "OnDropped")]
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
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[CallsUnknownMethods(Count = 1)]
	private void DoConditionUpdate()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoUpdate(UpdateFlags flags)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "Awake")]
	[CalledBy(Type = typeof(NPC), Member = "FindAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "MaybeReparentAnimatedInteractions")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAmbientVoiceOver()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_conditionupdate")]
	[CalledBy(Type = typeof(NPC), Member = "SetConditionUpdateEnabled")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTODHours()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(Action_NPCClearActive), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	public static void ClearActive()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CalledBy(Type = typeof(NPC), Member = "GetActive")]
	[CalledBy(Type = typeof(NPC), Member = "IsActive")]
	[CalledBy(Type = typeof(NPC), Member = "SetActive")]
	[CalledBy(Type = typeof(NPC), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(NPCPreventActiveTrigger), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "CanInteractWithItem")]
	[CallerCount(Count = 10)]
	public static bool HasActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "CanInteractWithItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public static bool IsActive(string guid)
	{
		return false;
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
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(NPC), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void FindAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(NPC), Member = "DoUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void UpdateAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
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
