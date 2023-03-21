using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Platform;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct InitializeThreadAffinityInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private ulong m_NetworkWork;

	private ulong m_StorageIo;

	private ulong m_WebSocketIo;

	private ulong m_P2PIo;

	private ulong m_HttpRequestIo;

	public ulong NetworkWork
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ulong);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ulong StorageIo
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		get
		{
			return default(ulong);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ulong WebSocketIo
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return default(ulong);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ulong P2PIo
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return default(ulong);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ulong HttpRequestIo
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return default(ulong);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public void Set(InitializeThreadAffinity other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "set_OverrideThreadAffinity")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
