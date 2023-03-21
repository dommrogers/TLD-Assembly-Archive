using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Base : MonoBehaviour
{
	protected UIPanel m_Panel;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 76)]
	public virtual void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 54)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 73)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Panel_Base()
	{
	}
}
