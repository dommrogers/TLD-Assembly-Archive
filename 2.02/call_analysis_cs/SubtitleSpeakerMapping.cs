using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class SubtitleSpeakerMapping
{
	public string m_SpeakerID;

	public LocalizedString m_SpeakerName;

	public Color m_SpeakerTextColor;

	public bool m_OverrideSpeakerColor;

	public Color m_SpeakerNameColor;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SubtitleSpeakerMapping()
	{
	}
}
