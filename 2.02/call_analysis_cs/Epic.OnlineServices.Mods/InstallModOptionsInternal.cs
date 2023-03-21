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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ModIdentifier Mod
	{
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	public bool RemoveAfterExit
	{
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_Mod")]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_RemoveAfterExit")]
	public void Set(InstallModOptions other)
	{
	}

	[CalledBy(Type = typeof(ModsInterface), Member = "InstallMod")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_Mod")]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "set_RemoveAfterExit")]
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
