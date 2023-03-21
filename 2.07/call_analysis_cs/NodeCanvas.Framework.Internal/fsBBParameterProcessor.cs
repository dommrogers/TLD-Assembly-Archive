using System;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;

namespace NodeCanvas.Framework.Internal;

public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType>
{
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsSerializer), Member = ".ctor")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
	{
	}

	[CallerCount(Count = 0)]
	public fsBBParameterProcessor()
	{
		((fsRecoveryProcessor<, >)(object)this)._002Ector();
	}
}
