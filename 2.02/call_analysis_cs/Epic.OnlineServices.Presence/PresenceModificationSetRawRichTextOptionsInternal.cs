using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct PresenceModificationSetRawRichTextOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_RichText;

	public string RichText
	{
		[CalledBy(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "set_RichText")]
	public void Set(PresenceModificationSetRawRichTextOptions other)
	{
	}

	[CalledBy(Type = typeof(PresenceModification), Member = "SetRawRichText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "set_RichText")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
