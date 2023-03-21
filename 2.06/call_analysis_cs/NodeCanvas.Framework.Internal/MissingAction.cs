using System;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Framework.Internal;

public class MissingAction : ActionTask, IMissingRecoverable
{
	private string _missingType;

	private string _recoveryState;

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002EmissingType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		set
		{
		}
	}

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002ErecoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		get
		{
			return null;
		}
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "SplitInternal")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissingAction()
	{
	}
}
