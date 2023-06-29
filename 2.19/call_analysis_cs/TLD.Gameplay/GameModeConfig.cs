using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Logging;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay;

public abstract class GameModeConfig : ScriptableObject
{
	protected static readonly LogFilter s_LogFilter;

	public SaveSlotType m_SaveSlotType;

	public ExperienceMode m_XPMode;

	private MissionServicesManager m_MissionServicesPrefab;

	public SceneLoadCondition[] m_LoadConditions;

	public bool m_StartRegionSelectionBlocked;

	protected List<GameplayTag> m_ActiveTags;

	private LocalizedString m_ModeName;

	private LocalizedString m_Description;

	public LocalizedString m_LoadingText;

	public string m_SpriteName;

	private MissionServicesManager m_MissionServicesManager;

	public LocalizedString Name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	public LocalizedString Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
	}

	public virtual StartGearData StartGear
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateMissionServicesManager")]
	[CalledBy(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameModeConfig), Member = "CreateMissionServicesManager")]
	public MissionServicesManager GetMissionServicesManager(bool createIfNeeded)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "DestroyMissionServicesManager")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "EndGame")]
	[CalledBy(Type = typeof(GameModeConfig), Member = "EndGame")]
	[CalledBy(Type = typeof(GameModeConfig), Member = "Unselected")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DestroyMissionServicesManager()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	public bool HasActiveTag(GameplayTag tag)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Selected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameModeConfig), Member = "CreateMissionServicesManager")]
	public virtual void StartGame()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameModeConfig), Member = "DestroyMissionServicesManager")]
	public virtual void EndGame()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SaveGame(SlotData slotData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void LoadGame(string slotName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameModeConfig), Member = "DestroyMissionServicesManager")]
	public virtual void Unselected()
	{
	}

	[CalledBy(Type = typeof(GameModeConfig), Member = "GetMissionServicesManager")]
	[CalledBy(Type = typeof(GameModeConfig), Member = "StartGame")]
	[CalledBy(Type = typeof(SandboxConfig), Member = "StartGame")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void CreateMissionServicesManager()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected GameModeConfig()
	{
	}
}
