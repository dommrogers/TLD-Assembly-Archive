using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Framework.Internal;

public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable
{
	private string _missingType;

	private string _recoveryState;

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002EmissingType
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002ErecoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 14)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public MissingBBParameterType()
	{
		((BBParameter<>)(object)this)._002Ector();
	}
}
