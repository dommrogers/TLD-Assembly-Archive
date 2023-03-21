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
			return 0uL;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ulong StorageIo
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return 0uL;
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
		[CallerCount(Count = 35)]
		get
		{
			return 0uL;
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
		[CallerCount(Count = 9)]
		get
		{
			return 0uL;
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
			return 0uL;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public void Set(InitializeThreadAffinity other)
	{
	}

	[CalledBy(Type = typeof(InitializeOptionsInternal), Member = "set_OverrideThreadAffinity")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
