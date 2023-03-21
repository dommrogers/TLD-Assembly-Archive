using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Tasks.Actions;

public class ExecuteStaticFunction_Multiplatform : ActionTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BBObjectParameter, object> _003C_003E9__9_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal object _003COnExecute_003Eb__9_0(BBObjectParameter p)
		{
			return null;
		}
	}

	protected SerializedMethodInfo method;

	protected List<BBObjectParameter> parameters;

	protected BBObjectParameter returnValue;

	private MethodInfo targetMethod
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
		[CallsUnknownMethods(Count = 28)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Release")]
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Acquire")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 7)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "SetMethod")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	protected override string OnInit()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 5)]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ExecuteStaticFunction_Multiplatform()
	{
	}
}
