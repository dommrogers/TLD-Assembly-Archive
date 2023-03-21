using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

public class QueryFileListOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private string[] _003CListOfTags_003Ek__BackingField;

	public ProductUserId LocalUserId
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

	public string[] ListOfTags
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public QueryFileListOptions()
	{
	}
}
