using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Framework.Internal;

public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable
{
	private string _missingType;

	private string _recoveryState;

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002EmissingType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	private string ParadoxNotion_002ESerialization_002EIMissingRecoverable_002ErecoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public MissingBBParameterType()
	{
		((BBParameter<>)(object)this)._002Ector();
	}
}
