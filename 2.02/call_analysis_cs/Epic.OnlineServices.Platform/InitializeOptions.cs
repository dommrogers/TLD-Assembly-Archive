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
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public ReallocateMemoryFunc ReallocateMemoryFunction
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

	public ReleaseMemoryFunc ReleaseMemoryFunction
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string ProductName
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	public string ProductVersion
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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

	public IntPtr SystemInitializeOptions
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		get
		{
			return default(IntPtr);
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
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public InitializeOptions()
	{
	}
}
