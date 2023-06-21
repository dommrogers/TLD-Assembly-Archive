using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StruggleDamageEventUISettings : ScriptableObject
{
	public string m_IconName;

	public LocalizedString m_DamageEventName;

	public LocalizedString m_DamageEventType;

	public Color m_TintColor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public StruggleDamageEventUISettings()
	{
	}
}
