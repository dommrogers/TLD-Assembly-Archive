using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class RichPresenceProviderBase : IRichPresenceProvider
{
	protected PresenceType m_CurrentPresence;

	private bool m_PresenceHasChanged;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	public void SetPresence(PresenceType presenceType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RichPresenceProviderBase), Member = "UpdateRichPresence")]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	protected abstract bool IsUserSignedOn();

	protected abstract void ChangePresence();

	[CalledBy(Type = typeof(RichPresenceProviderBase), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void UpdateRichPresence()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected RichPresenceProviderBase()
	{
	}
}
