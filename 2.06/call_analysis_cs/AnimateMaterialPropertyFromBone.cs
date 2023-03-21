using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimateMaterialPropertyFromBone : MonoBehaviour
{
	private enum MaterialPropertyType
	{
		Float,
		Vector
	}

	[Serializable]
	private class AnimatedPropertyData
	{
		public TransformAxis m_AnimatedAxis;

		public string m_MaterialPropertyName;

		[NonSerialized]
		public int m_MaterialPropertyID;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public AnimatedPropertyData()
		{
		}
	}

	private Transform m_Bone;

	private TransformAxis m_AnimatedAxis;

	private MaterialPropertyType m_MaterialPropertyType;

	private int m_VectorPropertyIndex;

	private Vector4 m_VectorPropertyDefaultValue;

	private string m_MaterialPropertyName;

	private AnimatedPropertyData[] m_MultiPropertyData;

	private Renderer[] m_AffectedRenderers;

	private MaterialPropertyBlock m_MaterialPropertyBlock;

	private int m_MaterialPropertyID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID")]
	[CallsUnknownMethods(Count = 9)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[Calls(Type = typeof(Vector4), Member = "set_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public AnimateMaterialPropertyFromBone()
	{
	}
}
