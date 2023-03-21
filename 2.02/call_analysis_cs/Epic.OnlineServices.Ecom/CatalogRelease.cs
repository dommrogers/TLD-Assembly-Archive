using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CatalogRelease : ISettable
{
	private string[] _003CCompatibleAppIds_003Ek__BackingField;

	private string[] _003CCompatiblePlatforms_003Ek__BackingField;

	private string _003CReleaseNote_003Ek__BackingField;

	public string[] CompatibleAppIds
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
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

	public string[] CompatiblePlatforms
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string ReleaseNote
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "get_CompatibleAppIds")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "get_CompatiblePlatforms")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "get_ReleaseNote")]
	[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(CatalogReleaseInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CatalogRelease), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CatalogRelease()
	{
	}
}
