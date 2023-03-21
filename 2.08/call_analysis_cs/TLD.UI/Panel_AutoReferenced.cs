using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI;

public abstract class Panel_AutoReferenced : Panel_Base
{
	protected PanelReference m_SelfReference;

	public PanelReference SelfReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected Panel_AutoReferenced()
	{
	}
}
