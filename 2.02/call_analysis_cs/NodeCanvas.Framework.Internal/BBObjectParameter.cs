using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;

namespace NodeCanvas.Framework.Internal;

[Serializable]
public class BBObjectParameter : BBParameter<object>
{
	private Type _type;

	public override Type varType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public BBObjectParameter()
	{
		((BBParameter<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(SetEnum), Member = ".ctor")]
	[CalledBy(Type = typeof(SetEnum), Member = ".ctor")]
	[CalledBy(Type = typeof(CheckEnum), Member = ".ctor")]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(CheckEnum), Member = ".ctor")]
	[CalledBy(Type = typeof(Switch), Member = ".ctor")]
	[CallerCount(Count = 12)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "SetMethod")]
	public BBObjectParameter(Type t)
	{
		((BBParameter<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "SetMethod")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "SetMethod")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetType(Type t)
	{
	}
}
