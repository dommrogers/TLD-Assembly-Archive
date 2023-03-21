using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct ModIdentifierInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_NamespaceId;

	private IntPtr m_ItemId;

	private IntPtr m_ArtifactId;

	private IntPtr m_Title;

	private IntPtr m_Version;

	public string NamespaceId
	{
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ItemId
	{
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ArtifactId
	{
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Title
	{
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Version
	{
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_NamespaceId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_ItemId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_ArtifactId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_Title")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_Version")]
	public void Set(ModIdentifier other)
	{
	}

	[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "set_Mod")]
	[CalledBy(Type = typeof(UninstallModOptionsInternal), Member = "set_Mod")]
	[CalledBy(Type = typeof(UpdateModOptionsInternal), Member = "set_Mod")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "Set")]
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
