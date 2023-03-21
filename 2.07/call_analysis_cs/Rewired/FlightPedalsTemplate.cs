using System;
using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid;

	public const int elementId_leftPedal = 0;

	public const int elementId_rightPedal = 1;

	public const int elementId_slide = 2;

	private IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002EleftPedal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ControllerTemplate), Member = "GetElement")]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002ErightPedal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ControllerTemplate), Member = "GetElement")]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002Eslide
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ControllerTemplate), Member = "GetElement")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerTemplate), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public FlightPedalsTemplate(object payload)
		: base(null)
	{
	}
}
