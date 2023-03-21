using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct InstallModOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Mod;

	private int m_RemoveAfterExit;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public ModIdentifier Mod
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public bool RemoveAfterExit
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_RemoveAfterExit")]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_Mod")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_LocalUserId")]
	public void Set(InstallModOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_Mod")]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_RemoveAfterExit")]
	[CalledBy(Type = typeof(ModsInterface), Member = "InstallMod")]
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
