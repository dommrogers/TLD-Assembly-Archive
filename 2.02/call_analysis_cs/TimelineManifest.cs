using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimelineManifest : ScriptableObject
{
	public List<TimelineManifestEntry> m_List;

	[CalledBy(TypeFullName = "TimelineRef.<Load>d__17", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool TryGetEntry(string timelineFilenameNoExt, out TimelineManifestEntry resultTimelineManifestEntry)
	{
		resultTimelineManifestEntry = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public TimelineManifest()
	{
	}
}
