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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	public virtual bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 66)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool CanBeDestroyed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Panel_Base()
	{
	}
}
