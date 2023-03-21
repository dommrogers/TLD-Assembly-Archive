using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimelineManifest : ScriptableObject
{
	public List<TimelineManifestEntry> m_List;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(TimelineRef._003CLoad_003Ed__17), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool TryGetEntry(string timelineFilenameNoExt, out TimelineManifestEntry resultTimelineManifestEntry)
	{
		resultTimelineManifestEntry = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public TimelineManifest()
	{
	}
}
