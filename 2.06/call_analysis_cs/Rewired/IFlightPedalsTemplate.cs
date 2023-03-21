using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public interface IFlightPedalsTemplate : IControllerTemplate
{
	IControllerTemplateAxis leftPedal
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateAxis rightPedal
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateAxis slide
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}
}
