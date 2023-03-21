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

	[Calls(Type = typeof(RichPresenceProviderBase), Member = "UpdateRichPresence")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	protected abstract bool IsUserSignedOn();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	protected abstract void ChangePresence();

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CalledBy(Type = typeof(RichPresenceProviderBase), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateRichPresence()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected RichPresenceProviderBase()
	{
	}
}
