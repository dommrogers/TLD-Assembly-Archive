using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIGeometry
{
	public BetterList<Vector3> verts;

	public BetterList<Vector2> uvs;

	public BetterList<Color32> cols;

	private BetterList<Vector3> mRtpVerts;

	private Vector3 mRtpNormal;

	private Vector4 mRtpTan;

	public bool hasVertices
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool hasTransformed
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ApplyTransform(Matrix4x4 widgetToPanel)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "WriteToBuffers")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UIGeometry()
	{
	}
}
