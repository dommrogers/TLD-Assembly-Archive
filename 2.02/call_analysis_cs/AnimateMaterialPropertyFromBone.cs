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
		[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(Shader), Member = "PropertyToID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[Calls(Type = typeof(Vector4), Member = "set_Item")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AnimateMaterialPropertyFromBone()
	{
	}
}
