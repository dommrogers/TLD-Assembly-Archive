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
		[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static ReallocateMemoryFuncInternal ReallocateMemoryFunction
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static ReleaseMemoryFuncInternal ReleaseMemoryFunction
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string ProductName
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ProductVersion
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
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
		[Calls(Type = typeof(InitializeThreadAffinityInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "set_OverrideThreadAffinity")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "set_ProductVersion")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "set_ProductName")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "get_ReleaseMemoryFunction")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "get_ReallocateMemoryFunction")]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "get_AllocateMemoryFunction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void Set(InitializeOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InitializeOptionsInternal), Member = "Set")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
