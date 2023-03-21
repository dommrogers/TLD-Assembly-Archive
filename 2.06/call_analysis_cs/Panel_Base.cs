using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Base : MonoBehaviour
{
	protected UIPanel m_Panel;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 67)]
	public virtual void Initialize()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public virtual bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 65)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual bool IsOverlayPanel()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual bool CanBeDestroyed()
	{
		return default(bool);
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Panel_Base()
	{
	}
}
