using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public class PageQuery : ISettable
{
	private int _003CStartIndex_003Ek__BackingField;

	private int _003CMaxCount_003Ek__BackingField;

	public int StartIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int MaxCount
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void Set(PageQueryInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PageQuery()
	{
	}
}
