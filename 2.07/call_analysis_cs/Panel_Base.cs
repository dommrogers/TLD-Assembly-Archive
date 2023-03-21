using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Base : MonoBehaviour
{
	protected UIPanel m_Panel;

	[CallerCount(Count = 67)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool IsEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 66)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_Base()
	{
	}
}
