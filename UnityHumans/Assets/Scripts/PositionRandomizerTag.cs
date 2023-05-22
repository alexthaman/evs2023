using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers;
using UnityEngine.Perception.Randomization.Samplers;

// Tag applied to objects that will interact with the PositionRandomizer 
public class PositionRandomizerTag : RandomizerTag
{
    private Vector3 center;

    protected override void OnEnable()
    {
        base.OnEnable();
        center = transform.position;
    }

    public void ApplyOffset(Vector3 offset)
    {
        transform.position = center + offset;
    }
}

// Randomly assigns a position for objects tagged with PositionRandomizer Tag.  Positions are assinged uniformly within the defined range for X, Y, and Z.
[Serializable]
public class PositionRandomizer : Randomizer
{
    public FloatParameter RangeX = new() { value = new UniformSampler(-1, 1) };
    public FloatParameter RangeY = new() { value = new UniformSampler(-1, 1) };
    public FloatParameter RangeZ = new() { value = new UniformSampler(-1, 1) };

    protected override void OnIterationStart()
    {
        foreach (var obj in GameObject.FindObjectsOfType<PositionRandomizerTag>())
        {
            obj.ApplyOffset(new Vector3(RangeX.Sample(), RangeY.Sample(), RangeZ.Sample()));
        }
    }
}
