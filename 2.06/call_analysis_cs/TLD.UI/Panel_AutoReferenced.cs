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

	[CalledBy(Type = typeof(Panel_List<, >), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnDestroy")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	protected Panel_AutoReferenced()
	{
	}
}
