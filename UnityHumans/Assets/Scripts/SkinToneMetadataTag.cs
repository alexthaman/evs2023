using UnityEngine;
using UnityEngine.Perception.GroundTruth.MetadataReporter;
using UnityEngine.Perception.GroundTruth.DataModel;

// SkinToneMetadatTag is used to report to the SOLO output the skin tone value that was used for the tagged person
public class SkinToneMetadataTag : LabeledMetadataTag
{
    protected override string key => "Person data";

    protected override void GetReportedValues(IMessageBuilder builder)
    {
        var strt = GetComponent<SkinToneRandomizerTag>();
        builder.AddFloat("Skin tone", strt.GetSkinTone());
    }
}
