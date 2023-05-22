using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Perception.Randomization.Randomizers;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Samplers;

// Tag applied to objects that will interact with the SkinToneRamdomizer
public class SkinToneRandomizerTag : RandomizerTag
{
    static int k_Tone = Shader.PropertyToID("tone");

    // Applies specified skin tone value to the skin material on the tagged person
    public void SetSkinTone(float skinToneValue)
    {
        var materials = GetComponent<Renderer>().materials.ToList();
        var skin = materials.First(m => m.name.StartsWith("Custom Skin Tone"));
        skin.SetFloat(k_Tone, skinToneValue);
    }

    // Retreives specified skin tone value to the skin material on the tagged person
    public float GetSkinTone()
    {
        var materials = GetComponent<Renderer>().materials.ToList();
        var skin = materials.First(m => m.name.StartsWith("Custom Skin Tone"));
        return skin.GetFloat(k_Tone);
    }
}

// Randomly assigns a position for objects tagged with PositionRandomizer Tag.  Skin tones are sampled uniformly within the range [0.0-0.8f]
public class SkinToneRandomizer : Randomizer
{
    public FloatParameter SkinRange = new() { value = new UniformSampler(0, 8.0f) };

    protected override void OnIterationStart()
    {
        foreach (var tag in tagManager.Query<SkinToneRandomizerTag>())
        {
            tag.SetSkinTone(SkinRange.Sample());
        }
    }
}
