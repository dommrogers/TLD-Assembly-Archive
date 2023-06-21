using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes.ObjectReferences;

namespace InteractiveObjects;

public class TrackableItemData : SceneObjectReference
{
	private string m_Guid;

	private string m_ActivityTags;

	public TrackableItemType m_TrackableItemType;

	public TransmitterData m_TransmitterData;

	public float m_MaximumRange;

	public float m_AudioRange;

	public float m_FullSignalRange;

	private readonly List<string> m_ResearchSets;

	public string Guid
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(TrackableItemsManager), Member = "FilterActiveItemsByResearchSet")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsActiveDueToResearchSet(string activeResearchSet)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneObjectReference), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TrackableItemData()
	{
	}
}
