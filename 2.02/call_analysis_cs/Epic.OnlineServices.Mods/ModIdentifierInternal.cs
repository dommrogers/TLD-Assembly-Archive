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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		set
		{
		}
	}

	public string ItemId
	{
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		set
		{
		}
	}

	public string ArtifactId
	{
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Title
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Version
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ModIdentifierInternal), Member = "Set")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_Version")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_Title")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_ItemId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_NamespaceId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "set_ArtifactId")]
	public void Set(ModIdentifier other)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "Set")]
	[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "set_Mod")]
	[CalledBy(Type = typeof(UninstallModOptionsInternal), Member = "set_Mod")]
	[CalledBy(Type = typeof(UpdateModOptionsInternal), Member = "set_Mod")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
