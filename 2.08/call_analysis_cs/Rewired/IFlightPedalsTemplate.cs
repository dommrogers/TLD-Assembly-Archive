using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public interface IFlightPedalsTemplate : IControllerTemplate
{
	IControllerTemplateAxis leftPedal
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	IControllerTemplateAxis rightPedal
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	IControllerTemplateAxis slide
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}
}
