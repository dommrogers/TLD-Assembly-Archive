using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetLinecastInfo2DAll : ActionTask<Transform>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RaycastHit2D, GameObject> _003C_003E9__7_0;

		public static Func<RaycastHit2D, float> _003C_003E9__7_1;

		public static Func<RaycastHit2D, Vector2> _003C_003E9__7_2;

		public static Func<RaycastHit2D, Vector2> _003C_003E9__7_3;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
		[CallsUnknownMethods(Count = 2)]
		internal GameObject _003COnExecute_003Eb__7_0(RaycastHit2D h)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		internal float _003COnExecute_003Eb__7_1(RaycastHit2D h)
		{
			return 0f;
		}

		[CallerCount(Count = 0)]
		internal Vector2 _003COnExecute_003Eb__7_2(RaycastHit2D h)
		{
			return default(Vector2);
		}

		[CallerCount(Count = 0)]
		internal Vector2 _003COnExecute_003Eb__7_3(RaycastHit2D h)
		{
			return default(Vector2);
		}
	}

	public BBParameter<GameObject> target;

	public LayerMask mask;

	public BBParameter<List<GameObject>> saveHitGameObjectsAs;

	public BBParameter<List<float>> saveDistancesAs;

	public BBParameter<List<Vector3>> savePointsAs;

	public BBParameter<List<Vector3>> saveNormalsAs;

	private RaycastHit2D[] hits;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Physics2D), Member = "LinecastAll")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Func<, >), Member = ".ctor")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 34)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	public GetLinecastInfo2DAll()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
