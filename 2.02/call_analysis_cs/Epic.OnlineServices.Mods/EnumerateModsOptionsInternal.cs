using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct EnumerateModsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private ModEnumerationType m_Type;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(EnumerateModsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(EnumerateModsOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public ModEnumerationType Type
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumerateModsOptionsInternal), Member = "set_LocalUserId")]
	public void Set(EnumerateModsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EnumerateModsOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(ModsInterface), Member = "EnumerateMods")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
