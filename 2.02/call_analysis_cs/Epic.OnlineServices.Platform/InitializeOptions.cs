using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Platform;

public class InitializeOptions
{
	private AllocateMemoryFunc _003CAllocateMemoryFunction_003Ek__BackingField;

	private ReallocateMemoryFunc _003CReallocateMemoryFunction_003Ek__BackingField;

	private ReleaseMemoryFunc _003CReleaseMemoryFunction_003Ek__BackingField;

	private string _003CProductName_003Ek__BackingField;

	private string _003CProductVersion_003Ek__BackingField;

	private IntPtr _003CSystemInitializeOptions_003Ek__BackingField;

	private InitializeThreadAffinity _003COverrideThreadAffinity_003Ek__BackingField;

	public AllocateMemoryFunc AllocateMemoryFunction
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

	public ReallocateMemoryFunc ReallocateMemoryFunction
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

	public ReleaseMemoryFunc ReleaseMemoryFunction
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

	public string ProductName
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

	public string ProductVersion
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

	public IntPtr SystemInitializeOptions
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return (IntPtr)0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public InitializeThreadAffinity OverrideThreadAffinity
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public InitializeOptions()
	{
	}
}
