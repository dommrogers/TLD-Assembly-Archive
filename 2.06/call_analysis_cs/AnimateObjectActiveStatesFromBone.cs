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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AnimateObjectActiveStatesFromBone()
	{
	}
}
