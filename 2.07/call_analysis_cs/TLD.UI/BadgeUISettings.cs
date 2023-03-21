using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI;

public class BadgeUISettings : ScriptableObject
{
	private Color m_ColorHeaderLocked;

	private Color m_ColorHeaderUnlocked;

	private Color m_ColorDescriptionLocked;

	private Color m_ColorDescriptionUnlocked;

	[CallerCount(Count = 0)]
	public Color GetHeaderColor(bool unlocked)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	public Color GetDescriptionColor(bool unlocked)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public BadgeUISettings()
	{
	}
}
