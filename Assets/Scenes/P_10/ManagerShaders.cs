using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ManagerShaders : MonoBehaviour
{
    [SerializeField] PostProcessVolume postProcessVolume;
    private ColorGrading _colorGrading;
    private Vignette _vignette;
    private Bloom _bloom;
    private ChromaticAberration _chromaticAberration;


    void Start()
    {
        postProcessVolume.profile.TryGetSettings(out _colorGrading);
        postProcessVolume.profile.TryGetSettings(out _vignette);
        postProcessVolume.profile.TryGetSettings(out _bloom);
        postProcessVolume.profile.TryGetSettings(out _chromaticAberration);
    }

    public void ApplyGrayscale()
    {
        ResetEffects();
        _colorGrading.saturation.value = -100;
    }

    public void ApplySepia()
    {
        ResetEffects();
        _colorGrading.saturation.value = 0;
        _colorGrading.colorFilter.value = new Color(1.2f, 1.0f, 0.8f);
    }

    public void ApplyChromaticAberration()
    {
        ResetEffects();
        _chromaticAberration.enabled.value = true;
        _chromaticAberration.intensity.value = 1.0f;
    }
    
    public void ApplyVignette()
    {
        ResetEffects();
        _vignette.enabled.value = true;
        _vignette.intensity.value = 0.45f;
        _vignette.smoothness.value = 0.75f;
    }

    public void ApplyBloom()
    {
        ResetEffects();
        _bloom.enabled.value = true;
        _bloom.intensity.value = 5f;
        _bloom.threshold.value = 1.1f;
    }
    
    public void ResetEffects()
    {
        _colorGrading.saturation.value = 0;
        _colorGrading.colorFilter.value = Color.white;
        _vignette.enabled.value = false;
        _bloom.enabled.value = false;
        _chromaticAberration.enabled.value = false;
    }
}
