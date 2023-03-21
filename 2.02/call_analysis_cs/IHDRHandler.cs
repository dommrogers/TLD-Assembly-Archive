using UnityEngine;

public interface IHDRHandler
{
	void SetPaperWhiteNits(float value);

	void SetPeakBrightnessNits(float value);

	bool IsOutputtingHDR();

	void Initialize(float paperWhiteNits, float peakBrightnessNits);

	void Render(RenderTexture source, RenderTexture destination);
}
