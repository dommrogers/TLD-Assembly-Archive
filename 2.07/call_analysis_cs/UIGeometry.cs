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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool hasTransformed
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CallerCount(Count = 4)]
	public void Clear()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void ApplyTransform(Matrix4x4 widgetToPanel)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(UIWidget), Member = "WriteToBuffers")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public UIGeometry()
	{
	}
}
