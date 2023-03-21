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
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002ErecoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override int maxOutConnections
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public override bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissingNode()
	{
	}
}
