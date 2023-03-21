using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct UpdateModOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Mod;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(UpdateModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UpdateModOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public ModIdentifier Mod
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CalledBy(Type = typeof(UpdateModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UpdateModOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateModOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(UpdateModOptionsInternal), Member = "set_Mod")]
	public void Set(UpdateModOptions other)
	{
	}

	[Calls(Type = typeof(UpdateModOptionsInternal), Member = "set_Mod")]
	[CalledBy(Type = typeof(ModsInterface), Member = "UpdateMod")]
	[Calls(Type = typeof(UpdateModOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
