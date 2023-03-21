using System;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;

namespace NodeCanvas.Framework.Internal;

public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsSerializer), Member = ".ctor")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 7)]
	public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
	{
	}

	[CallerCount(Count = 0)]
	public fsBBParameterProcessor()
	{
		((fsRecoveryProcessor<, >)(object)this)._002Ector();
	}
}
