using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class RichPresenceProviderBase : IRichPresenceProvider
{
	protected PresenceType m_CurrentPresence;

	private bool m_PresenceHasChanged;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	public void SetPresence(PresenceType presenceType)
	{
	}

	[Calls(Type = typeof(RichPresenceProviderBase), Member = "UpdateRichPresence")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract bool IsUserSignedOn();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void ChangePresence();

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CalledBy(Type = typeof(RichPresenceProviderBase), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	protected void UpdateRichPresence()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected RichPresenceProviderBase()
	{
	}
}
