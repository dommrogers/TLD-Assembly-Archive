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

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(HableCurve), Member = "InitSegments")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(HableCurve), Member = "Eval")]
		public float Eval(float x)
		{
			return default(float);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 toeSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 midSegmentA
		{
			[CallsUnknownMethods(Count = 3)]
			[CallerCount(Count = 0)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 midSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 shoSegmentA
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 shoSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return default(Vector4);
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
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
			return default(float);
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
			return default(float);
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(float);
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
			return default(float);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 20)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public HableCurve()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Segment), Member = "Eval")]
	[CallsUnknownMethods(Count = 3)]
	public float Eval(float x)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2")]
	[Calls(Type = typeof(HableCurve), Member = "InitSegments")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CallsUnknownMethods(Count = 1)]
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
	{
	}

	[CalledBy(Type = typeof(HableCurve), Member = "Init")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(Segment), Member = "Eval")]
	[Calls(Type = typeof(HableCurve), Member = "SolveAB")]
	[Calls(Type = typeof(HableCurve), Member = "EvalDerivativeLinearGamma")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HableCurve), Member = "EvalDerivativeLinearGamma")]
	private void InitSegments(DirectParams srcParams)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(HableCurve), Member = "InitSegments")]
	[CallsUnknownMethods(Count = 2)]
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref lnA) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref B) = null;
	}

	[CallerCount(Count = 0)]
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref m) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref b) = null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HableCurve), Member = "InitSegments")]
	[CalledBy(Type = typeof(HableCurve), Member = "InitSegments")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
	{
		return default(float);
	}
}
