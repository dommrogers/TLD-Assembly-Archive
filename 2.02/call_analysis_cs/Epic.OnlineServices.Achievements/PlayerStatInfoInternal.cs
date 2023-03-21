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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerStatInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PlayerStatInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
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
		[CallerCount(Count = 6)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStatInfoInternal), Member = "set_Name")]
	public void Set(PlayerStatInfo other)
	{
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStatInfoInternal), Member = "set_Name")]
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
