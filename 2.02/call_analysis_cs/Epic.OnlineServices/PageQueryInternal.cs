using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

[StructLayout(0, Pack = 8, Size = 12)]
internal struct PageQueryInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private int m_StartIndex;

	private int m_MaxCount;

	public int StartIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int MaxCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public void Set(PageQuery other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
