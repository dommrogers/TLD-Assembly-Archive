using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetAllChildGameObjects : ActionTask<Transform>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Transform, GameObject> _003C_003E9__4_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal GameObject _003COnExecute_003Eb__4_0(Transform t)
		{
			return null;
		}
	}

	public BBParameter<List<GameObject>> saveAs;

	public bool recursive;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[CallsUnknownMethods(Count = 29)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[CalledBy(Type = typeof(GetAllChildGameObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[CallsUnknownMethods(Count = 19)]
	private List<Transform> Get(Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetAllChildGameObjects()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
