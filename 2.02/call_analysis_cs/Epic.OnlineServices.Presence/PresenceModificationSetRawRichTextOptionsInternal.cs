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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "Set")]
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
	[Calls(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "set_RichText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
