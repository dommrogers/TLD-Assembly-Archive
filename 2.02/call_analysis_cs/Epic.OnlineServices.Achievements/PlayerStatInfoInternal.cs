using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct PlayerStatInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Name;

	private int m_CurrentValue;

	private int m_ThresholdValue;

	public string Name
	{
		[CalledBy(Type = typeof(PlayerStatInfo), Member = "Set")]
		[CalledBy(Type = typeof(PlayerStatInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PlayerStatInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PlayerStatInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public int CurrentValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	public int ThresholdValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
	[Calls(Type = typeof(PlayerStatInfoInternal), Member = "set_Name")]
	public void Set(PlayerStatInfo other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStatInfoInternal), Member = "set_Name")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
