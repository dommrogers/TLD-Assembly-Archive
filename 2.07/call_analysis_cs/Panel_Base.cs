using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Base : MonoBehaviour
{
	protected UIPanel m_Panel;

	[CallerCount(Count = 67)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	public virtual void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool IsEnabled()
	{
		return false;
	}

	[CallerCount(Count = 66)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual bool IsOverlayPanel()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual bool CanBeDestroyed()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_Base()
	{
	}
}
