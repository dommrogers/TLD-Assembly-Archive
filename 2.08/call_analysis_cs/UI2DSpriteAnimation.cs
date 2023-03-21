using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	protected int framerate;

	public bool ignoreTimeScale;

	public bool loop;

	public Sprite[] frames;

	private SpriteRenderer mUnitySprite;

	private UI2DSprite mNguiSprite;

	private int mIndex;

	private float mUpdate;

	public bool isPlaying
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		get
		{
			return default(bool);
		}
	}

	public int framesPerSecond
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	public void Play()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Pause()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallerCount(Count = 0)]
	public void ResetToBeginning()
	{
	}

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 4)]
	private void UpdateSprite()
	{
	}

	[CallerCount(Count = 0)]
	public UI2DSpriteAnimation()
	{
	}
}
