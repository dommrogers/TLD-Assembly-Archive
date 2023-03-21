using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public class HableCurve
{
	private class Segment
	{
		public float offsetX;

		public float offsetY;

		public float scaleX;

		public float scaleY;

		public float lnA;

		public float B;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public float Eval(float x)
		{
			return 0f;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Segment()
		{
		}
	}

	private struct DirectParams
	{
		internal float x0;

		internal float y0;

		internal float x1;

		internal float y1;

		internal float W;

		internal float overshootX;

		internal float overshootY;

		internal float gamma;
	}

	public class Uniforms
	{
		private HableCurve parent;

		public Vector4 curve
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 toeSegmentA
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 toeSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 midSegmentA
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 midSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 shoSegmentA
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 shoSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return default(Vector4);
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 282)]
		internal Uniforms(HableCurve parent)
		{
		}
	}

	private float _003CwhitePoint_003Ek__BackingField;

	private float _003CinverseWhitePoint_003Ek__BackingField;

	private float _003Cx0_003Ek__BackingField;

	private float _003Cx1_003Ek__BackingField;

	private readonly Segment[] m_Segments;

	public readonly Uniforms uniforms;

	public float whitePoint
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public float inverseWhitePoint
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	internal float x0
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	internal float x1
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public HableCurve()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public float Eval(float x)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HableCurve), Member = "InitSegments")]
	[CallsUnknownMethods(Count = 2)]
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
	{
	}

	[CalledBy(Type = typeof(HableCurve), Member = "Init")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void InitSegments(DirectParams srcParams)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
	{
		lnA = default(float);
		B = default(float);
	}

	[CallerCount(Count = 0)]
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
	{
		m = default(float);
		b = default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
	{
		return 0f;
	}
}
