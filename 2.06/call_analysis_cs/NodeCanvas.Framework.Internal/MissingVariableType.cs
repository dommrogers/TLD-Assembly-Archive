using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Framework.Internal;

public class MissingVariableType : Variable<object>, IMissingRecoverable
{
	private string _missingType;

	private string _recoveryState;

	public string missingType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		set
		{
		}
	}

	public string recoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 31)]
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

	[CallerCount(Count = 0)]
	public MissingVariableType()
	{
		((Variable<>)(object)this)._002Ector();
	}
}
