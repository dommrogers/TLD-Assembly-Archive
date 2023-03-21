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
		[CallerCount(Count = 6)]
		public ObjectParams()
		{
		}
	}

	private Transform m_Bone;

	private TransformAxis m_AnimatedAxis;

	private ObjectParams[] m_Objects;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AnimateObjectActiveStatesFromBone()
	{
	}
}
