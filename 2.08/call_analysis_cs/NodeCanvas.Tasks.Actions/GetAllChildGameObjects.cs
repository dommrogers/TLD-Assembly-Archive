using System;
using System.Collections.Generic;
using System.Linq;
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
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal GameObject _003COnExecute_003Eb__4_0(Transform t)
		{
			return null;
		}
	}

	public BBParameter<List<GameObject>> saveAs;

	public bool recursive;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 20)]
	protected override void OnExecute()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[CalledBy(Type = typeof(GetAllChildGameObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[CallsUnknownMethods(Count = 13)]
	private List<Transform> Get(Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GetAllChildGameObjects()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
