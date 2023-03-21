using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class TimelineManifestEntry
{
	public string m_AssetBundleFileName;

	public string m_AssetPath;

	public string m_AssetGUID;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public TimelineManifestEntry()
	{
	}
}
