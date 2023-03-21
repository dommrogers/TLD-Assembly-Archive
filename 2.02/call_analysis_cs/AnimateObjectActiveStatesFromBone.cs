using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimateObjectActiveStatesFromBone : MonoBehaviour
{
	[Serializable]
	private class ObjectParams
	{
		public GameObject m_Object;

		public MinMax m_ValueRange;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ObjectParams()
		{
		}
	}

	private Transform m_Bone;

	private TransformAxis m_AnimatedAxis;

	private ObjectParams[] m_Objects;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AnimateObjectActiveStatesFromBone()
	{
	}
}
