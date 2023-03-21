using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay;

public abstract class GameModeConfig : ScriptableObject
{
	public SaveSlotType m_SaveSlotType;

	public ExperienceMode m_XPMode;

	public SceneLoadCondition[] m_LoadConditions;

	public bool m_StartRegionSelectionBlocked;

	protected List<GameplayTag> m_ActiveTags;

	private LocalizedString m_ModeName;

	private LocalizedString m_Description;

	public LocalizedString m_LoadingText;

	public string m_SpriteName;

	public LocalizedString Name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	public bool HasActiveTag(GameplayTag tag)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected GameModeConfig()
	{
	}
}
