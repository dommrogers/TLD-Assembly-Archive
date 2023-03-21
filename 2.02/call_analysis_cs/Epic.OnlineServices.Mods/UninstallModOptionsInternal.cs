using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct UninstallModOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Mod;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UninstallModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UninstallModOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ModIdentifier Mod
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CalledBy(Type = typeof(UninstallModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UninstallModOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UninstallModOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(UninstallModOptionsInternal), Member = "set_Mod")]
	public void Set(UninstallModOptions other)
	{
	}

	[CalledBy(Type = typeof(ModsInterface), Member = "UninstallMod")]
	[Calls(Type = typeof(UninstallModOptionsInternal), Member = "set_Mod")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UninstallModOptionsInternal), Member = "set_LocalUserId")]
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
