using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class StatThresholds : ISettable
{
	private string _003CName_003Ek__BackingField;

	private int _003CThreshold_003Ek__BackingField;

	public string Name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public int Threshold
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatThresholdsInternal), Member = "get_Name")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(StatThresholdsInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StatThresholdsInternal), Member = "get_Name")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public StatThresholds()
	{
	}
}
