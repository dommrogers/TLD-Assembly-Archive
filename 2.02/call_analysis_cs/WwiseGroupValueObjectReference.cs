using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class WwiseGroupValueObjectReference : WwiseObjectReference
{
	public abstract WwiseObjectReference GroupObjectReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	public abstract WwiseObjectType GroupWwiseObjectType
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	public override string DisplayName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WwiseObjectReference), Member = ".ctor")]
	protected WwiseGroupValueObjectReference()
	{
	}
}
