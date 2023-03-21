using System;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Utils;

namespace Rewired.Internal;

public static class ControllerTemplateFactory
{
	private static readonly Type[] _defaultTemplateTypes;

	private static readonly Type[] _defaultTemplateInterfaceTypes;

	public static Type[] templateTypes
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public static Type[] templateInterfaceTypes
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ExternalTools), Member = "CreateControllerTemplate")]
	[Calls(Type = typeof(ControllerTemplate), Member = ".ctor")]
	[CallerCount(Count = 1)]
	public static IControllerTemplate Create(Guid typeGuid, object payload)
	{
		return null;
	}
}
