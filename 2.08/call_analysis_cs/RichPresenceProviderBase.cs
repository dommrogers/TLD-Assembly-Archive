using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class RichPresenceProviderBase : IRichPresenceProvider
{
	protected PresenceType m_CurrentPresence;

	private bool m_PresenceHasChanged;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RichPresenceProviderBase), Member = "UpdateRichPresence")]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	protected abstract bool IsUserSignedOn();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	protected abstract void ChangePresence();

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
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
