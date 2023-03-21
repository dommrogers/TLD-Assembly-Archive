using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Platform;

[StructLayout(0, Pack = 8, Size = 72)]
internal struct InitializeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private AllocateMemoryFuncInternal m_AllocateMemoryFunction;

	private ReallocateMemoryFuncInternal m_ReallocateMemoryFunction;

	private ReleaseMemoryFuncInternal m_ReleaseMemoryFunction;

	private IntPtr m_ProductName;

	private IntPtr m_ProductVersion;

	private IntPtr m_Reserved;

	private IntPtr m_SystemInitializeOptions;

	private IntPtr m_OverrideThreadAffinity;

	private static AllocateMemoryFuncInternal s_AllocateMemoryFunction;

	private static ReallocateMemoryFuncInternal s_ReallocateMemoryFunction;

	private static ReleaseMemoryFuncInternal s_ReleaseMemoryFunction;

	public static AllocateMemoryFuncInternal AllocateMemoryFunction
	{
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static ReallocateMemoryFuncInternal ReallocateMemoryFunction
	{
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static ReleaseMemoryFuncInternal ReleaseMemoryFunction
	{
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string ProductName
	{
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ProductVersion
	{
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public IntPtr SystemInitializeOptions
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public InitializeThreadAffinity OverrideThreadAffinity
	{
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InitializeThreadAffinityInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "get_AllocateMemoryFunction")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "get_ReallocateMemoryFunction")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "get_ReleaseMemoryFunction")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "set_ProductName")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "set_ProductVersion")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "set_OverrideThreadAffinity")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void Set(InitializeOptions other)
	{
	}

	[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "Set")]
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
