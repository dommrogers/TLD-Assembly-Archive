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
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		set
		{
		}
	}

	public string recoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 47)]
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
