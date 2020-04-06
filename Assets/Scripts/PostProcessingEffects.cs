using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingEffects : MonoBehaviour {

    public EnemyManager enemyManager;
    public PostProcessProfile profile;
    public MinMax effectDistanceRange;
    public MinMax occlusionIntensityRange;
    public MinMax lensDistortionRange;
    public MinMax colorTemperatureRange;

    ChromaticAberration chromaticAberration;
    AmbientOcclusion ambientOcclusion;
    Grain grain;
    LensDistortion lensDistortion;
    ColorGrading colorGrading;

    void Awake() {
        chromaticAberration = profile.GetSetting<ChromaticAberration>();
        ambientOcclusion = profile.GetSetting<AmbientOcclusion>();
        grain = profile.GetSetting<Grain>();
        lensDistortion = profile.GetSetting<LensDistortion>();
        colorGrading = profile.GetSetting<ColorGrading>();
    }

    void Update() {
        float currentEnemyDistance = enemyManager.GetPlayerDistanceToClosestEnemy(effectDistanceRange.max);
        UpdatePostProcessingValues(1 - effectDistanceRange.PercentageOfValueInRange(currentEnemyDistance));
    }

    void UpdatePostProcessingValues(float percentage) {
        chromaticAberration.intensity.value = percentage;
        ambientOcclusion.intensity.value = occlusionIntensityRange.Lerp(percentage);
        grain.intensity.value = percentage;
        lensDistortion.intensity.value = lensDistortionRange.ReverseLerp(percentage);
        colorGrading.temperature.value = colorTemperatureRange.Lerp(percentage);
    }

    void OnDestroy() {
        UpdatePostProcessingValues(0);
    }
}
