using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class WwiseGroupValueObjectReference : WwiseObjectReference
{
	public abstract WwiseObjectReference GroupObjectReference { get; set; }

	public abstract WwiseObjectType GroupWwiseObjectType { get; }

	public override string DisplayName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
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
