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

	public string recoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 37)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MissingVariableType()
	{
		((Variable<>)(object)this)._002Ector();
	}
}
