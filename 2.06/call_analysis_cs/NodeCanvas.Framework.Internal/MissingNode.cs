using System;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Framework.Internal;

public sealed class MissingNode : Node, IMissingRecoverable
{
	private string _missingType;

	private string _recoveryState;

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002EmissingType
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002ErecoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	public override string name
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override Type outConnectionType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override int maxInConnections
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	public override Alignment2x2 iconAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	public MissingNode()
	{
	}
}
