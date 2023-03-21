using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

public class ModIdentifier : ISettable
{
	private string _003CNamespaceId_003Ek__BackingField;

	private string _003CItemId_003Ek__BackingField;

	private string _003CArtifactId_003Ek__BackingField;

	private string _003CTitle_003Ek__BackingField;

	private string _003CVersion_003Ek__BackingField;

	public string NamespaceId
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public string ItemId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string ArtifactId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public string Title
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public string Version
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_Version")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_Title")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_ItemId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_NamespaceId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_ArtifactId")]
	internal void Set(ModIdentifierInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ModIdentifier), Member = "Set")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ModIdentifier()
	{
	}
}
