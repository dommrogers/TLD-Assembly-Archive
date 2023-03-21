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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 18)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(GetAllChildGameObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GetAllChildGameObjects), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
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
