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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string ItemId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public string ArtifactId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
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
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	public string Version
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ModIdentifier), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_NamespaceId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_ItemId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_ArtifactId")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_Title")]
	[Calls(Type = typeof(ModIdentifierInternal), Member = "get_Version")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(ModIdentifierInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ModIdentifier), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ModIdentifier()
	{
	}
}
