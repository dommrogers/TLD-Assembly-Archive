namespace UnityEngine.Rendering.PostProcessing;

internal static class ShaderIDs
{
	internal static readonly int MainTex;

	internal static readonly int Jitter;

	internal static readonly int Sharpness;

	internal static readonly int FinalBlendParameters;

	internal static readonly int HistoryTex;

	internal static readonly int SMAA_Flip;

	internal static readonly int SMAA_Flop;

	internal static readonly int AOParams;

	internal static readonly int AOColor;

	internal static readonly int OcclusionTexture1;

	internal static readonly int OcclusionTexture2;

	internal static readonly int SAOcclusionTexture;

	internal static readonly int MSVOcclusionTexture;

	internal static readonly int DepthCopy;

	internal static readonly int LinearDepth;

	internal static readonly int LowDepth1;

	internal static readonly int LowDepth2;

	internal static readonly int LowDepth3;

	internal static readonly int LowDepth4;

	internal static readonly int TiledDepth1;

	internal static readonly int TiledDepth2;

	internal static readonly int TiledDepth3;

	internal static readonly int TiledDepth4;

	internal static readonly int Occlusion1;

	internal static readonly int Occlusion2;

	internal static readonly int Occlusion3;

	internal static readonly int Occlusion4;

	internal static readonly int Combined1;

	internal static readonly int Combined2;

	internal static readonly int Combined3;

	internal static readonly int SSRResolveTemp;

	internal static readonly int Noise;

	internal static readonly int Test;

	internal static readonly int Resolve;

	internal static readonly int History;

	internal static readonly int ViewMatrix;

	internal static readonly int InverseViewMatrix;

	internal static readonly int InverseProjectionMatrix;

	internal static readonly int ScreenSpaceProjectionMatrix;

	internal static readonly int Params2;

	internal static readonly int FogColor;

	internal static readonly int FogParams;

	internal static readonly int VelocityScale;

	internal static readonly int MaxBlurRadius;

	internal static readonly int RcpMaxBlurRadius;

	internal static readonly int VelocityTex;

	internal static readonly int Tile2RT;

	internal static readonly int Tile4RT;

	internal static readonly int Tile8RT;

	internal static readonly int TileMaxOffs;

	internal static readonly int TileMaxLoop;

	internal static readonly int TileVRT;

	internal static readonly int NeighborMaxTex;

	internal static readonly int LoopCount;

	internal static readonly int DepthOfFieldTemp;

	internal static readonly int DepthOfFieldTex;

	internal static readonly int Distance;

	internal static readonly int LensCoeff;

	internal static readonly int MaxCoC;

	internal static readonly int RcpMaxCoC;

	internal static readonly int RcpAspect;

	internal static readonly int CoCTex;

	internal static readonly int TaaParams;

	internal static readonly int AutoExposureTex;

	internal static readonly int HistogramBuffer;

	internal static readonly int Params;

	internal static readonly int ScaleOffsetRes;

	internal static readonly int BloomTex;

	internal static readonly int SampleScale;

	internal static readonly int Threshold;

	internal static readonly int ColorIntensity;

	internal static readonly int Bloom_DirtTex;

	internal static readonly int Bloom_Settings;

	internal static readonly int Bloom_Color;

	internal static readonly int Bloom_DirtTileOffset;

	internal static readonly int ChromaticAberration_Amount;

	internal static readonly int ChromaticAberration_SpectralLut;

	internal static readonly int Distortion_CenterScale;

	internal static readonly int Distortion_Amount;

	internal static readonly int Lut2D;

	internal static readonly int Lut3D;

	internal static readonly int Lut3D_Params;

	internal static readonly int Lut2D_Params;

	internal static readonly int NoiseParams;

	internal static readonly int NoiseTex;

	internal static readonly int UserLut2D_Params;

	internal static readonly int PostExposure;

	internal static readonly int ColorBalance;

	internal static readonly int ColorFilter;

	internal static readonly int HueSatCon;

	internal static readonly int Brightness;

	internal static readonly int ChannelMixerRed;

	internal static readonly int ChannelMixerGreen;

	internal static readonly int ChannelMixerBlue;

	internal static readonly int Lift;

	internal static readonly int InvGamma;

	internal static readonly int Gain;

	internal static readonly int Curves;

	internal static readonly int CustomToneCurve;

	internal static readonly int ToeSegmentA;

	internal static readonly int ToeSegmentB;

	internal static readonly int MidSegmentA;

	internal static readonly int MidSegmentB;

	internal static readonly int ShoSegmentA;

	internal static readonly int ShoSegmentB;

	internal static readonly int Lut1A;

	internal static readonly int Lut1B;

	internal static readonly int Lut2A;

	internal static readonly int Lut2B;

	internal static readonly int LutPain;

	internal static readonly int LutStim;

	internal static readonly int LutElectrocution;

	internal static readonly int LutBoost;

	internal static readonly int LutHeadache;

	internal static readonly int LutSuffocation;

	internal static readonly int LutAux;

	internal static readonly int BlendAuxAmount;

	internal static readonly int BlendAmounts;

	internal static readonly int EffectOverrideBlendAmounts;

	internal static readonly int EffectOverrideBlendAmounts2;

	internal static readonly int BlendAdjustments;

	internal static readonly int Vignette_Color;

	internal static readonly int Vignette_Center;

	internal static readonly int Vignette_Settings;

	internal static readonly int Vignette_Mask;

	internal static readonly int Vignette_Opacity;

	internal static readonly int Vignette_Mode;

	internal static readonly int Grain_Params1;

	internal static readonly int Grain_Params2;

	internal static readonly int GrainTex;

	internal static readonly int Phase;

	internal static readonly int GrainNoiseParameters;

	internal static readonly int LumaInAlpha;

	internal static readonly int DitheringTex;

	internal static readonly int Dithering_Coords;

	internal static readonly int From;

	internal static readonly int To;

	internal static readonly int Interp;

	internal static readonly int TargetColor;

	internal static readonly int HalfResFinalCopy;

	internal static readonly int WaveformSource;

	internal static readonly int WaveformBuffer;

	internal static readonly int VectorscopeBuffer;

	internal static readonly int RenderViewportScaleFactor;

	internal static readonly int UVTransform;

	internal static readonly int DepthSlice;

	internal static readonly int UVScaleOffset;

	internal static readonly int PosScaleOffset;
}
